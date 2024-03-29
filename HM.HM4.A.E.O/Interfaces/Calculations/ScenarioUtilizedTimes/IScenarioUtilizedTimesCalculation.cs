﻿namespace HM.HM4.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesCalculation
    {
        IScenarioUtilizedTimes Calculate(
            IScenarioUtilizedTimesResultElementFactory scenarioUtilizedTimesResultElementFactory,
            IScenarioUtilizedTimesFactory scenarioUtilizedTimesFactory,
            IScenarioUtilizedTimesResultElementCalculation scenarioUtilizedTimesResultElementCalculation,
            IΛ Λ,
            Isrt srt,
            Ih h,
            In n,
            Ix x);
    }
}