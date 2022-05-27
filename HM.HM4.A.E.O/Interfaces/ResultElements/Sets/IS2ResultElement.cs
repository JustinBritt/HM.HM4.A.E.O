namespace HM.HM4.A.E.O.Interfaces.ResultElements.Sets
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IS2ResultElement
    {
        IrIndexElement rIndexElement { get; }

        IdIndexElement d1IndexElement { get; }

        IdIndexElement d2IndexElement { get; }
    }
}