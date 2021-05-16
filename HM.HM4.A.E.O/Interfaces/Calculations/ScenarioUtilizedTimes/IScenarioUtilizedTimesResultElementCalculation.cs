namespace HM.HM4.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesResultElementCalculation
    {
        IScenarioUtilizedTimesResultElement Calculate(
            IScenarioUtilizedTimesResultElementFactory scenarioUtilizedTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            Isrt srt,
            Ih h,
            In n,
            Ix x);
    }
}