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

    internal sealed class δ2Calculation : Iδ2Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ2Calculation()
        {
        }

        public Iδ2 Calculate(
            Iδ2ParameterElementFactory δ2ParameterElementFactory,
            Iδ2Factory δ2Factory,
            Iδ2ParameterElementCalculation δ2ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iβ β,
            Iγ γ)
        {
            return δ2Factory.Create(
                srd.Value
                .Select(x =>
                δ2ParameterElementCalculation.Calculate(
                    δ2ParameterElementFactory,
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