namespace HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IzResultElement
    {
        IsIndexElement sIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        bool Value { get; }
    }
}