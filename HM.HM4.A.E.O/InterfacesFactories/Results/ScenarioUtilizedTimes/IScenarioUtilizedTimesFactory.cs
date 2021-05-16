namespace HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesFactory
    {
        IScenarioUtilizedTimes Create(
            ImmutableList<IScenarioUtilizedTimesResultElement> value);
    }
}