namespace HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IrtCrossJoinElementFactory
    {
        IrtCrossJoinElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);
    }
}