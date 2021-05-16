namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IstCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}