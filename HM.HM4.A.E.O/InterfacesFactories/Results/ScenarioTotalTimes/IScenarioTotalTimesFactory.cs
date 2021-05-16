namespace HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioTotalTimes;

    public interface IScenarioTotalTimesFactory
    {
        IScenarioTotalTimes Create(
            ImmutableList<IScenarioTotalTimesResultElement> value);
    }
}