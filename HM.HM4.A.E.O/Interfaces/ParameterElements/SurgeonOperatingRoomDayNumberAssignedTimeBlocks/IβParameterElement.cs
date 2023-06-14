namespace HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IβParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}