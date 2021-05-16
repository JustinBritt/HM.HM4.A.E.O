namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;

    public interface ISurgeonNumberAssignedWeekdaysFactory
    {
        ISurgeonNumberAssignedWeekdays Create(
            ImmutableList<ISurgeonNumberAssignedWeekdaysResultElement> value);
    }
}