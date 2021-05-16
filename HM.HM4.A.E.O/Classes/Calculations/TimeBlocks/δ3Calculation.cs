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

    internal sealed class δ3Calculation : Iδ3Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ3Calculation()
        {
        }

        public Iδ3 Calculate(
            Iδ3ParameterElementFactory δ3ParameterElementFactory,
            Iδ3Factory δ3Factory,
            Iδ3ParameterElementCalculation δ3ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iβ β,
            Iγ γ)
        {
            return δ3Factory.Create(
                srd.Value
                .Select(x =>
                δ3ParameterElementCalculation.Calculate(
                    δ3ParameterElementFactory,
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