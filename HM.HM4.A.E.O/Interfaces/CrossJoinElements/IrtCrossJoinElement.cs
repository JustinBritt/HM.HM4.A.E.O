namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IrtCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}