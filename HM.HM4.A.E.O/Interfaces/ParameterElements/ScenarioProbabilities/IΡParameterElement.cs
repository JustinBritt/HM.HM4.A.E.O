﻿namespace HM.HM4.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IΡParameterElement
    {
        IΛIndexElement ΛIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}