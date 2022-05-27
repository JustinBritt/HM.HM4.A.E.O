namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;

    public interface IS2ResultElementFactory
    {
        IS2ResultElement Create(
            IrIndexElement rIndexElement,
            IdIndexElement d1IndexElement,
            IdIndexElement d2IndexElement);
    }
}