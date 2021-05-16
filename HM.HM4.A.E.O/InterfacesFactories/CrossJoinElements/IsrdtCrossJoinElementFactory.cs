namespace HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IsrdtCrossJoinElementFactory
    {
        IsrdtCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement);
    }
}