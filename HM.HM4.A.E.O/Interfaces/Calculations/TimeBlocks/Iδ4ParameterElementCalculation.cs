namespace HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    public interface Iδ4ParameterElementCalculation
    {
        Iδ4ParameterElement Calculate(
            Iδ4ParameterElementFactory δ4ParameterElementFactory,
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            It t,
            IW W,
            Iγ γ,
            Iδ3 δ3);
    }
}