namespace HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    public interface Iδ4Calculation
    {
        Iδ4 Calculate(
            Iδ4ParameterElementFactory δ4ParameterElementFactory,
            Iδ4Factory δ4Factory,
            Iδ4ParameterElementCalculation δ4ParameterElementCalculation,
            Isrd srd,
            It t,
            IW W,
            Iδ3 δ3,
            Iγ γ);
    }
}