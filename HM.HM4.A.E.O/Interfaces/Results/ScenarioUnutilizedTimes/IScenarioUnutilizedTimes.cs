namespace HM.HM4.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioUnutilizedTimes
    {
        ImmutableList<IScenarioUnutilizedTimesResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IΛIndexElement ΛIndexElement);

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}