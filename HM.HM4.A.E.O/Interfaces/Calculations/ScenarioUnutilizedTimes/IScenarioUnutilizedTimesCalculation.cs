﻿namespace HM.HM4.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes
{
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesCalculation
    {
        IScenarioUnutilizedTimes Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IScenarioUnutilizedTimesFactory scenarioUnutilizedTimesFactory,
            IScenarioUnutilizedTimesResultElementCalculation scenarioUnutilizedTimesResultElementCalculation,
            IΛ Λ,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes);
    }
}