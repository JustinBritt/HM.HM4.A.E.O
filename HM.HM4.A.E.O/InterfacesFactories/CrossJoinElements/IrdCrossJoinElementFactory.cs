namespace HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IrdCrossJoinElementFactory
    {
        IrdCrossJoinElement Create(
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement);
    }
}