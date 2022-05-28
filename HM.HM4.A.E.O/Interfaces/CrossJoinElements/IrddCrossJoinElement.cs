namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IrddCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        IdIndexElement d1IndexElement { get; }

        IdIndexElement d2IndexElement { get; }
    }
}