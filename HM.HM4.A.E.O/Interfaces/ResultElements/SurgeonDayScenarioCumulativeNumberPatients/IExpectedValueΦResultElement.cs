﻿namespace HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IExpectedValueΦResultElement
    {
        IsIndexElement sIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}