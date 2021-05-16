namespace HM.HM4.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysResultElement
    {
        IjIndexElement jIndexElement { get; }

        int Value { get; }
    }
}