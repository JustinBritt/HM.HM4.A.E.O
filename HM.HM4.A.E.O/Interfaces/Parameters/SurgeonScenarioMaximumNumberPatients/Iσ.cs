﻿namespace HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface Iσ
    {
        ImmutableList<IσParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}