namespace HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβParameterElementFactory
    {
        IβParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            INullableValue<int> value);
    }
}