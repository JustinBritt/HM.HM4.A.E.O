﻿namespace HM.HM4.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;

    public interface IScenarioUnutilizedTimesResultElementCalculation
    {
        IScenarioUnutilizedTimesResultElement Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes);
    }
}