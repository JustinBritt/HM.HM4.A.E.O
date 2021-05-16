namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.IndexElements;

    public interface IIndexElementsAbstractFactory
    {
        IdIndexElementFactory CreatedIndexElementFactory();

        IjIndexElementFactory CreatejIndexElementFactory();

        IlIndexElementFactory CreatelIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        ItIndexElementFactory CreatetIndexElementFactory();

        IΛIndexElementFactory CreateΛIndexElementFactory();
    }
}