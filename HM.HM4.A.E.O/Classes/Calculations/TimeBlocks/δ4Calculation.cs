namespace HM.HM4.A.E.O.Classes.Calculations.TimeBlocks
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    internal sealed class δ4Calculation : Iδ4Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4Calculation()
        {
        }

        public Iδ4 Calculate(
            Iδ4ParameterElementFactory δ4ParameterElementFactory,
            Iδ4Factory δ4Factory,
            Iδ4ParameterElementCalculation δ4ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iδ3 δ3,
            Iγ γ)
        {
            return δ4Factory.Create(
                srd.Value
                .SelectMany(b =>
                t.GetNthElementsAt(
                    b.dIndexElement.Value.Value.Value,
                    t.GetT() - W.Value.Value.Value + b.dIndexElement.Value.Value.Value,
                    W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.sIndexElement, a.rIndexElement, a.dIndexElement, b))
                .Select(x =>
                δ4ParameterElementCalculation.Calculate(
                    δ4ParameterElementFactory,
                    x.Item3,
                    x.Item2,
                    x.Item1,
                    x.Item4,
                    t,
                    W,
                    γ,
                    δ3))
                .ToImmutableList());
        }
    }
}