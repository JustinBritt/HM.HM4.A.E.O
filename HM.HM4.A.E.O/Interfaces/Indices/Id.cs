namespace HM.HM4.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface Id
    {
        ImmutableList<IdIndexElement> Value { get; }

        IdIndexElement GetElementAt(
            PositiveInt value);
    }
}