namespace HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    public interface Iδ1Calculation
    {
        Iδ1 Calculate(
            Iδ1ParameterElementFactory δ1ParameterElementFactory,
            Iδ1Factory δ1Factory,
            Iδ1ParameterElementCalculation δ1ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iβ β,
            Iγ γ);
    }
}