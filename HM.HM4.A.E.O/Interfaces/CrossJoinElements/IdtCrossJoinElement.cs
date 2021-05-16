namespace HM.HM4.A.E.O.Interfaces.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IdtCrossJoinElement
    {
        IdIndexElement dIndexElement { get; }

        ItIndexElement tIndexElement { get; }
    }
}