namespace HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface Iδ4ParameterElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        ItIndexElement tIndexElement { get; }

        int Value { get; }
    }
}