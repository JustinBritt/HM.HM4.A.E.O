﻿namespace HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUtilizedTimesResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}