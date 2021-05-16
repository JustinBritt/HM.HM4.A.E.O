namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IslCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IlIndexElement lIndexElement { get; }
    }
}