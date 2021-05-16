namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;

    public interface ISurgeonNumberAssignedWeekdaysResultElementFactory
    {
        ISurgeonNumberAssignedWeekdaysResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}