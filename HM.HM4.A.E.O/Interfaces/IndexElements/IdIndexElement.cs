﻿namespace HM.HM4.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IdIndexElement : IComparable<IdIndexElement>
    {
        /// <summary>
        /// Gets the weekday.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}