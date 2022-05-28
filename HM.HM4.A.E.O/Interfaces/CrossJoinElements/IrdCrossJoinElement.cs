namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IrdCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        IdIndexElement dIndexElement { get; }
    }
}