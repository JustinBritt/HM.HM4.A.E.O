﻿namespace HM.HM4.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IEBS
    {
        ImmutableList<IEBSResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement);

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            It t,
            IΛ Λ);
    }
}