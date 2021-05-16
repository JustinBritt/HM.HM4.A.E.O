namespace HM.HM4.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class IHat : IIHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHat(
            ImmutableList<IIHatResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IIHatResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.tIndexElement == tIndexElement && x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.tIndexElement.Value,
                    (INullableValue<int>)i.ΛIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        i.Value)))
                .ToImmutableList();
        }
    }
}