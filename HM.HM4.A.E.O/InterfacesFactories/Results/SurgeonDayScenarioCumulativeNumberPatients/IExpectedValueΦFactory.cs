namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IExpectedValueΦFactory
    {
        IExpectedValueΦ Create(
            ImmutableList<IExpectedValueΦResultElement> value);
    }
}