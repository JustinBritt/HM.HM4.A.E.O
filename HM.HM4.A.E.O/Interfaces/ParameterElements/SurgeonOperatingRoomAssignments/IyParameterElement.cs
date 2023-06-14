namespace HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IyParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}