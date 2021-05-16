namespace HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IxResultElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        bool Value { get; }
    }
}