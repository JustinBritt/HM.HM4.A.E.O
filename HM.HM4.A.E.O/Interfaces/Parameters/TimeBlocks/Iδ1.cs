namespace HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;

    public interface Iδ1
    {
        ImmutableList<Iδ1ParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement);
    }
}