namespace HM.HM4.A.E.O.Classes.Models
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.Interfaces.Contexts;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Models;
    using HM.HM4.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class HM4Model : IHM4Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4Model(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM4InputContext HM4InputContext)
        {
            this.Context = HM4InputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // d
            this.d = indicesAbstractFactory.CreatedFactory().Create(
                this.Context.Weekdays
                .Select(x => indexElementsAbstractFactory.CreatedIndexElementFactory().Create(x))
                .ToImmutableList());

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(x))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create(x))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // t
            this.t = indicesAbstractFactory.CreatetFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatetIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // Λ
            this.Λ = indicesAbstractFactory.CreateΛFactory().Create(
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateΛIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // dt
            this.dt = crossJoinsAbstractFactory.CreatedtFactory().Create(
                this.d.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatedtCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rdd
            this.rdd = crossJoinsAbstractFactory.CreaterddFactory().Create(
                this.r.Value
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreaterdCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreaterddCrossJoinElementFactory().Create(a.rIndexElement, a.dIndexElement, b))
                .ToImmutableList());

            // rt
            this.rt = crossJoinsAbstractFactory.CreatertFactory().Create(
                this.r.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatertCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // slΛ
            this.slΛ = crossJoinsAbstractFactory.CreateslΛFactory().Create(
               this.s.Value
               .SelectMany(b => this.l.Value, (a, b) => crossJoinElementsAbstractFactory.CreateslCrossJoinElementFactory().Create(a, b))
               .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreateslΛCrossJoinElementFactory().Create(a.sIndexElement, a.lIndexElement, b))
               .ToImmutableList());

            // sr
            this.sr = crossJoinsAbstractFactory.CreatesrFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // srd
            this.srd = crossJoinsAbstractFactory.CreatesrdFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrdCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // srt
            this.srt = crossJoinsAbstractFactory.CreatesrtFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrtCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // st
            this.st = crossJoinsAbstractFactory.CreatestFactory().Create(
                this.s.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatestCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sΛ
            this.sΛ = crossJoinsAbstractFactory.CreatesΛFactory().Create(
                this.s.Value
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // tΛ
            this.tΛ = crossJoinsAbstractFactory.CreatetΛFactory().Create(
                this.t.Value
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatetΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // H
            this.H = parametersAbstractFactory.CreateHFactory().Create(
                this.Context.TimeBlockLength);

            // h(s, Λ)
            this.h = parametersAbstractFactory.CreatehFactory().Create(
                this.Context.SurgeonScenarioWeightedAverageSurgicalDurations
                .Select(x => parameterElementsAbstractFactory.CreatehParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // L(s)
            this.L = parametersAbstractFactory.CreateLFactory().Create(
                this.Context.SurgeonLengthOfStayMaximums
                .Select(x => parameterElementsAbstractFactory.CreateLParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // n(s, Λ)
            this.n = parametersAbstractFactory.CreatenFactory().Create(
                this.Context.SurgeonScenarioMaximumNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreatenParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // p(s, l, Λ)
            this.p = parametersAbstractFactory.CreatepFactory().Create(
                this.Context.SurgeonDayScenarioLengthOfStayProbabilities
                .Select(x => parameterElementsAbstractFactory.CreatepParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    this.Λ.GetElementAt(x.Item3),
                    (FhirDecimal)x.Item4))
                .ToImmutableList());

            // W
            this.W = parametersAbstractFactory.CreateWFactory().Create(
                this.Context.NumberDaysPerWeek);

            // y(s, r)
            this.y = parametersAbstractFactory.CreateyFactory().Create(
                this.Context.SurgeonOperatingRoomAssignments
                .Select(x => parameterElementsAbstractFactory.CreateyParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.r.GetElementAt(x.Item2),
                    (FhirBoolean)x.Item3))
                .ToImmutableList());

            // β(s, r, d)
            this.β = parametersAbstractFactory.CreateβFactory().Create(
                this.Context.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateβParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.r.GetElementAt(x.Item2),
                    this.d.GetElementAt(x.Item3),
                    x.Item4))
                .ToImmutableList());

            // γ(r, t)
            this.γ = parametersAbstractFactory.CreateγFactory().Create(
                this.Context.OperatingRoomDayAssignedAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateγParameterElementFactory().Create(
                    this.r.GetElementAt(x.Item1),
                    this.t.GetElementAt(x.Item2),
                    (FhirBoolean)x.Item3))
                .ToImmutableList());

            // Δ(j)
            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => parameterElementsAbstractFactory.CreateΔParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    x.Item2.Select(i => this.s.GetElementAt(i)).ToImmutableList()))
                .ToImmutableList());

            // δ1(s, r, d)
            this.δ1 = calculationsAbstractFactory.Createδ1CalculationFactory().Create().Calculate(
                parameterElementsAbstractFactory.Createδ1ParameterElementFactory(),
                parametersAbstractFactory.Createδ1Factory(),
                calculationsAbstractFactory.Createδ1ParameterElementCalculationFactory().Create(),
                this.srd,
                this.t,
                this.W,
                this.β,
                this.γ);

            // δ2(s, r, d)
            this.δ2 = calculationsAbstractFactory.Createδ2CalculationFactory().Create().Calculate(
                parameterElementsAbstractFactory.Createδ2ParameterElementFactory(),
                parametersAbstractFactory.Createδ2Factory(),
                calculationsAbstractFactory.Createδ2ParameterElementCalculationFactory().Create(),
                this.srd,
                this.t,
                this.W,
                this.β,
                this.γ);

            // δ3(s, r, d)
            this.δ3 = calculationsAbstractFactory.Createδ3CalculationFactory().Create().Calculate(
                parameterElementsAbstractFactory.Createδ3ParameterElementFactory(),
                parametersAbstractFactory.Createδ3Factory(),
                calculationsAbstractFactory.Createδ3ParameterElementCalculationFactory().Create(),
                this.srd,
                this.t,
                this.W,
                this.β,
                this.γ);

            // δ4(s, r, d, t)
            this.δ4 = calculationsAbstractFactory.Createδ4CalculationFactory().Create().Calculate(
                parameterElementsAbstractFactory.Createδ4ParameterElementFactory(),
                parametersAbstractFactory.Createδ4Factory(),
                calculationsAbstractFactory.Createδ4ParameterElementCalculationFactory().Create(),
                this.srd,
                this.t,
                this.W,
                this.δ3,
                this.γ);

            // μ(s, Λ)
            this.μ = parametersAbstractFactory.CreateμFactory().Create(
                this.Context.SurgeonScenarioMaximumNumberPatientMeans
                .Select(x => parameterElementsAbstractFactory.CreateμParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt(x.Item2),
                    (FhirDecimal)x.Item3))
                .ToImmutableList());

            // Ρ(Λ)
            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                this.Context.ScenarioProbabilities
                .Select(x => parameterElementsAbstractFactory.CreateΡParameterElementFactory().Create(
                    this.Λ.GetElementAt(x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

            // σ(s, Λ)
            this.σ = parametersAbstractFactory.CreateσFactory().Create(
               this.Context.SurgeonScenarioMaximumNumberPatientStandardDeviations
               .Select(x => parameterElementsAbstractFactory.CreateσParameterElementFactory().Create(
                   this.s.GetElementAt(x.Item1),
                   this.Λ.GetElementAt(x.Item2),
                   (FhirDecimal)x.Item3))
               .ToImmutableList());

            // ΦHat(s, l, Λ)
            this.ΦHat = parametersAbstractFactory.CreateΦHatFactory().Create(
                this.Context.SurgeonDayScenarioCumulativeNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreateΦHatParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    this.Λ.GetElementAt(x.Item3),
                    (FhirDecimal)x.Item4))
                .ToImmutableList());

            // Ω
            this.Ω = parametersAbstractFactory.CreateΩFactory().Create(
                this.Context.MaximumNumberRecoveryWardBeds);

            // Variables

            // IHat(t, Λ)
            this.IHat = variablesAbstractFactory.CreateIHatFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.t.Value, 
                    indexSet2: this.Λ.Value, 
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous)); 

            // x(s, r, t)
            this.x = variablesAbstractFactory.CreatexFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.r.Value, 
                    indexSet3: this.t.Value)); 

            // z(s, t)
            this.z = variablesAbstractFactory.CreatezFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.t.Value)); 

            // Constraints

            // Constraints 1
            this.Model.AddConstraints(
                this.srd.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints1ConstraintElementFactory().Create(
                        x.dIndexElement,
                        x.rIndexElement,
                        x.sIndexElement,
                        this.t,
                        this.W,
                        this.β,
                        this.x)
                    .Value));

            // Constraints 2
            this.Model.AddConstraints(
                this.st.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints2ConstraintElementFactory().Create(
                        x.sIndexElement,
                        x.tIndexElement,
                        this.r,
                        this.x,
                        this.z)
                    .Value));

            // Constraints 3
            this.Model.AddConstraints(
                this.rt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.tIndexElement,
                        this.s,
                        this.γ,
                        this.x)
                    .Value));

            // Constraints 4
            this.Model.AddConstraints(
                this.srt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        x.tIndexElement,
                        this.y,
                        this.x)
                    .Value));

            // Constraints 5L
            this.Model.AddConstraints(
                this.srd.Value
                .SelectMany(b =>
                this.t.GetNthElementsAt(
                    b.dIndexElement.Value.Value.Value,
                    this.t.GetT() - this.W.Value.Value.Value + b.dIndexElement.Value.Value.Value,
                    this.W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.sIndexElement, a.rIndexElement, a.dIndexElement, b))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5LConstraintElementFactory().Create(
                        x.Item3,
                        x.Item2,
                        x.Item1,
                        x.Item4,
                        this.t,
                        this.W,
                        this.δ1,
                        this.δ4,
                        this.x)
                    .Value));

            // Constraints 5U
            this.Model.AddConstraints(
                this.srd.Value
                .SelectMany(b =>
                this.t.GetNthElementsAt(
                    b.dIndexElement.Value.Value.Value,
                    this.t.GetT() - this.W.Value.Value.Value + b.dIndexElement.Value.Value.Value,
                    this.W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.sIndexElement, a.rIndexElement, a.dIndexElement, b))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5UConstraintElementFactory().Create(
                        x.Item3,
                        x.Item2,
                        x.Item1,
                        x.Item4,
                        this.t,
                        this.W,
                        this.δ2,
                        this.δ4,
                        this.x)
                    .Value));

            // Constraints 6
            this.Model.AddConstraints(
                this.tΛ.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints6ConstraintElementFactory().Create(
                        x.tIndexElement,
                        x.ΛIndexElement,
                        this.l,
                        this.t,
                        this.st,
                        this.ΦHat,
                        this.IHat,
                        this.z)
                    .Value));

            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.t,
                    this.Λ,
                    this.Ρ,
                    this.IHat)
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public IHM4InputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Interfaces.Indices.Id d { get; }

        public Ij j { get; }

        public Il l { get; }

        public Ir r { get; }

        public Is s { get; }

        public It t { get; }

        public IΛ Λ { get; }

        public Idt dt { get; }

        public Irdd rdd { get; }

        public Irt rt { get; }

        public IslΛ slΛ { get; }

        public Isr sr { get; }

        public Isrd srd { get; }

        public Isrt srt { get; }

        public Ist st { get; }

        public IsΛ sΛ { get; }

        public ItΛ tΛ { get; }

        public IH H { get; }

        public Ih h { get; }

        public IL L { get; }

        public In n { get; }

        public Ip p { get; }

        public IW W { get; }

        public Iy y { get; }

        public Iβ β { get; }

        public Iγ γ { get; }

        public IΔ Δ { get; }

        public Iδ1 δ1 { get; }

        public Iδ2 δ2 { get; }

        public Iδ3 δ3 { get; }

        public Iδ4 δ4 { get; }

        public Iμ μ { get; }

        public IΡ Ρ { get; }

        public Iσ σ { get; }

        public IΦHat ΦHat { get; }

        public IΩ Ω { get; }

        public IIHat IHat { get; }

        public Ix x { get; }

        public Iz z { get; }
    }
}