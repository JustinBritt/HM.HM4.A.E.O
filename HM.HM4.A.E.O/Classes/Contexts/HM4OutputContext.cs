namespace HM.HM4.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Solver;

    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.Interfaces.Contexts;
    using HM.HM4.A.E.O.Interfaces.Models;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;

    internal sealed class HM4OutputContext : IHM4OutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4OutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM4Model HM4Model,
            Solution solution)
        {
            if (solution.ModelStatus == ModelStatus.Feasible)
            {
                // BestBound
                this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                    (decimal)solution.BestBound)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // Gap
                this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                    (decimal)solution.Gap)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // IsFeasible
                this.IsFeasible = dependenciesAbstractFactory.CreateNullableValueFactory().Create<bool>(
                    true);

                // NumberOfExploredNodes
                this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                    solution.NumberOfExploredNodes)
                    .GetValueForOutputContext();

                // ObjectiveValue
                this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                    (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // OverallWallTime
                this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                    solution.OverallWallTime)
                    .GetValueForOutputContext();

                // IHat(t, Λ)
                this.DayScenarioRecoveryWardCensuses = HM4Model.IHat.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreateIHatResultElementFactory(),
                    resultsAbstractFactory.CreateIHatFactory(),
                    HM4Model.t,
                    HM4Model.Λ)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // x(s, r, t)
                Ix x = HM4Model.x.GetElementsAt(
                    resultElementsAbstractFactory.CreatexResultElementFactory(),
                    resultsAbstractFactory.CreatexFactory(),
                    HM4Model.r,
                    HM4Model.s,
                    HM4Model.t);

                this.SurgeonOperatingRoomDayAssignments = x
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // S1
                this.S1 = calculationsAbstractFactory.CreateS1CalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateS1ResultElementFactory(),
                    resultsAbstractFactory.CreateS1Factory(),
                    HM4Model.r,
                    HM4Model.Δ,
                    x)
                    .GetValueForOutputContext()
                    .ToImmutableSortedSet(new HM.HM4.A.E.O.Classes.Comparers.LocationComparer());

                // S2
                this.S2 = calculationsAbstractFactory.CreateS2CalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateS2ResultElementFactory(),
                    resultsAbstractFactory.CreateS2Factory(),
                    HM4Model.d,
                    HM4Model.d,
                    HM4Model.r,
                    HM4Model.t,
                    HM4Model.rdd,
                    HM4Model.W,
                    HM4Model.Δ,
                    x)
                    .GetValueForOutputContext();

                // SurgeonNumberAssignedOperatingRooms
                this.SurgeonNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory(),
                    resultsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsFactory(),
                    calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                    HM4Model.s,
                    x)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgeonNumberAssignedWeekdays
                this.SurgeonNumberAssignedWeekdays = calculationsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysResultElementFactory(),
                    resultsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysFactory(),
                    calculationsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory().Create(),
                    HM4Model.s,
                    x)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgeonScenarioNumberPatients
                ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients = calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementFactory(),
                    resultsAbstractFactory.CreateSurgeonScenarioNumberPatientsFactory(),
                    calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory().Create(),
                    HM4Model.rt,
                    HM4Model.sΛ,
                    HM4Model.n,
                    x);

                this.SurgeonScenarioNumberPatients = surgeonScenarioNumberPatients.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM4Model.s,
                    HM4Model.Λ);

                // ScenarioNumberPatients(Λ)
                this.ScenarioNumberPatients = calculationsAbstractFactory.CreateScenarioNumberPatientsCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioNumberPatientsResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioNumberPatientsFactory(),
                    calculationsAbstractFactory.CreateScenarioNumberPatientsResultElementCalculationFactory().Create(),
                    HM4Model.Λ,
                    surgeonScenarioNumberPatients)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgicalSpecialtyNumberAssignedOperatingRooms
                this.SurgicalSpecialtyNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory(),
                    resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory(),
                    calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                    HM4Model.Δ,
                    x)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // SurgicalSpecialtyNumberAssignedWeekdays
                this.SurgicalSpecialtyNumberAssignedWeekdays = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory().Create().Calculate(
                    resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory(),
                    resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysFactory(),
                    calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory().Create(),
                    HM4Model.Δ,
                    x)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // z(s, t) 
                Interfaces.Results.SurgeonDayAssignments.Iz z = HM4Model.z.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreatezResultElementFactory(),
                    resultsAbstractFactory.CreatezFactory(),
                    HM4Model.s,
                    HM4Model.t);

                this.SurgeonDayAssignments = z
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ExpectedValueΦ(s, l, Λ)
                Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients.IExpectedValueΦ expectedValueΦ = calculationsAbstractFactory.CreateExpectedValueΦCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateExpectedValueΦResultElementFactory(),
                    resultsAbstractFactory.CreateExpectedValueΦFactory(),
                    calculationsAbstractFactory.CreateExpectedValueΦResultElementCalculationFactory().Create(),
                    HM4Model.l,
                    HM4Model.s,
                    HM4Model.t,
                    HM4Model.Λ,
                    HM4Model.slΛ,
                    HM4Model.L,
                    HM4Model.p,
                    HM4Model.μ);

                // VarianceΦ(s, l, Λ)
                Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients.IVarianceΦ varianceΦ = calculationsAbstractFactory.CreateVarianceΦCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateVarianceΦResultElementFactory(),
                    resultsAbstractFactory.CreateVarianceΦFactory(),
                    calculationsAbstractFactory.CreateVarianceΦResultElementCalculationFactory().Create(),
                    HM4Model.l,
                    HM4Model.s,
                    HM4Model.t,
                    HM4Model.Λ,
                    HM4Model.slΛ,
                    HM4Model.L,
                    HM4Model.p,
                    HM4Model.μ,
                    HM4Model.σ);

                // ExpectedValueI(t, Λ)
                Interfaces.Results.DayScenarioRecoveryWardUtilizations.IExpectedValueI expectedValueI = calculationsAbstractFactory.CreateExpectedValueICalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateExpectedValueIResultElementFactory(),
                    resultsAbstractFactory.CreateExpectedValueIFactory(),
                    calculationsAbstractFactory.CreateExpectedValueIResultElementCalculationFactory().Create(),
                    HM4Model.l,
                    HM4Model.t,
                    HM4Model.st,
                    HM4Model.tΛ,
                    expectedValueΦ,
                    z);

                this.DayScenarioRecoveryWardUtilizationExpectedValues = expectedValueI
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM4Model.t,
                    HM4Model.Λ);

                // VarianceI(t, Λ)
                Interfaces.Results.DayScenarioRecoveryWardUtilizations.IVarianceI varianceI = calculationsAbstractFactory.CreateVarianceICalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateVarianceIResultElementFactory(),
                    resultsAbstractFactory.CreateVarianceIFactory(),
                    calculationsAbstractFactory.CreateVarianceIResultElementCalculationFactory().Create(),
                    HM4Model.l,
                    HM4Model.t,
                    HM4Model.st,
                    HM4Model.tΛ,
                    varianceΦ,
                    z);

                this.DayScenarioRecoveryWardUtilizationVariances = varianceI
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM4Model.t,
                    HM4Model.Λ);

                // EBS(t, Λ)
                Interfaces.Results.DayScenarioExpectedBedShortages.IEBS EBS = calculationsAbstractFactory.CreateEBSCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateEBSResultElementFactory(),
                    resultsAbstractFactory.CreateEBSFactory(),
                    calculationsAbstractFactory.CreateEBSResultElementCalculationFactory().Create(),
                    HM4Model.tΛ,
                    HM4Model.Ω,
                    expectedValueI,
                    varianceI);

                this.DayScenarioExpectedBedShortages = EBS
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory(),
                    HM4Model.t,
                    HM4Model.Λ);

                // TEBS(Λ)
                Interfaces.Results.ScenarioTotalExpectedBedShortages.ITEBS TEBS_Λ = calculationsAbstractFactory.CreateTEBSΛCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateTEBSΛResultElementFactory(),
                    resultsAbstractFactory.CreateTEBSΛFactory(),
                    calculationsAbstractFactory.CreateTEBSΛResultElementCalculationFactory().Create(),
                    HM4Model.t,
                    HM4Model.Λ,
                    EBS);

                this.ScenarioTotalExpectedBedShortages = TEBS_Λ
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // TEBS
                this.TotalExpectedBedShortage = calculationsAbstractFactory.CreateTEBSCalculationFactory().Create()
                    .Calculate(
                    resultsAbstractFactory.CreateTEBSFactory(),
                    HM4Model.Λ,
                    HM4Model.Ρ,
                    TEBS_Λ)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioTotalTimes(Λ)
                IScenarioTotalTimes scenarioTotalTimes = calculationsAbstractFactory.CreateScenarioTotalTimesCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioTotalTimesResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioTotalTimesFactory(),
                    calculationsAbstractFactory.CreateScenarioTotalTimesResultElementCalculationFactory().Create(),
                    HM4Model.Λ,
                    HM4Model.srt,
                    HM4Model.H,
                    x);

                this.ScenarioTotalTimes = scenarioTotalTimes.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioUtilizedTimes(Λ)
                IScenarioUtilizedTimes scenarioUtilizedTimes = calculationsAbstractFactory.CreateScenarioUtilizedTimesCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioUtilizedTimesResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioUtilizedTimesFactory(),
                    calculationsAbstractFactory.CreateScenarioUtilizedTimesResultElementCalculationFactory().Create(),
                    HM4Model.Λ,
                    HM4Model.srt,
                    HM4Model.h,
                    HM4Model.n,
                    x);

                this.ScenarioUtilizedTimes = scenarioUtilizedTimes.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioUnutilizedTimes(Λ)
                IScenarioUnutilizedTimes scenarioUnutilizedTimes = calculationsAbstractFactory.CreateScenarioUnutilizedTimesCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioUnutilizedTimesResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioUnutilizedTimesFactory(),
                    calculationsAbstractFactory.CreateScenarioUnutilizedTimesResultElementCalculationFactory().Create(),
                    HM4Model.Λ,
                    scenarioTotalTimes,
                    scenarioUtilizedTimes);

                this.ScenarioUnutilizedTimes = scenarioUnutilizedTimes.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

                // ScenarioUnderutilizations(Λ)
                this.ScenarioUnderutilizations = calculationsAbstractFactory.CreateScenarioUnderutilizationsCalculationFactory().Create()
                    .Calculate(
                    resultElementsAbstractFactory.CreateScenarioUnderutilizationsResultElementFactory(),
                    resultsAbstractFactory.CreateScenarioUnderutilizationsFactory(),
                    calculationsAbstractFactory.CreateScenarioUnderutilizationsResultElementCalculationFactory().Create(),
                    HM4Model.Λ,
                    scenarioTotalTimes,
                    scenarioUnutilizedTimes)
                    .GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());
            } 
            else
            {
                this.IsFeasible = dependenciesAbstractFactory.CreateNullableValueFactory().Create<bool>(
                    false);
            }
        }

        public INullableValue<decimal> BestBound { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioExpectedBedShortages { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationExpectedValues { get; }

        public INullableValue<decimal> Gap { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        public INullableValue<bool> IsFeasible { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public ImmutableSortedSet<Location> S1 { get; }

        public ImmutableList<Tuple<Location, INullableValue<int>, INullableValue<int>>> S2 { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> ScenarioNumberPatients { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalTimes { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnderutilizations { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnutilizedTimes { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUtilizedTimes { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedWeekdays { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedWeekdays { get; }

        public INullableValue<decimal> TotalExpectedBedShortage { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalExpectedBedShortages { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationVariances { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> SurgeonDayAssignments { get; }
    }
}