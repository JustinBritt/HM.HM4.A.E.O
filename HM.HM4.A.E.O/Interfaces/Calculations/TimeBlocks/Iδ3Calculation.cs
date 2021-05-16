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

    public interface Iδ3Calculation
    {
        Iδ3 Calculate(
            Iδ3ParameterElementFactory δ3ParameterElementFactory,
            Iδ3Factory δ3Factory,
            Iδ3ParameterElementCalculation δ3ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iβ β,
            Iγ γ);
    }
}