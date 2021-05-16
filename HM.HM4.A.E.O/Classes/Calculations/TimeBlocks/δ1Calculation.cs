namespace HM.HM4.A.E.O.Classes.Calculations.TimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    internal sealed class δ1Calculation : Iδ1Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ1Calculation()
        {
        }

        public Iδ1 Calculate(
            Iδ1ParameterElementFactory δ1ParameterElementFactory,
            Iδ1Factory δ1Factory,
            Iδ1ParameterElementCalculation δ1ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iβ β,
            Iγ γ)
        {
            return δ1Factory.Create(
                srd.Value
                .Select(x =>
                δ1ParameterElementCalculation.Calculate(
                    δ1ParameterElementFactory,
                    x.dIndexElement,
                    x.rIndexElement,
                    x.sIndexElement,
                    t,
                    W,
                    β,
                    γ))
                .ToImmutableList());
        }
    }
}