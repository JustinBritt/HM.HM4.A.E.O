namespace HM.HM4.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface Ir
    {
        ImmutableList<IrIndexElement> Value { get; }

        IrIndexElement GetElementAt(
            Location value);
    }
}