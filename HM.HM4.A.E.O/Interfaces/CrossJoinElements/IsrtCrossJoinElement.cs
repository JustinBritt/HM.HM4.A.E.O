namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IsrtCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}