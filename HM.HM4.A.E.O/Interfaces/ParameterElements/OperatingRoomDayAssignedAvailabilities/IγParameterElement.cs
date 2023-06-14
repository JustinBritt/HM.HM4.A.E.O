namespace HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IγParameterElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}