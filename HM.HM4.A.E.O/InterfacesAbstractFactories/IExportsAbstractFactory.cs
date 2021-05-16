namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Exports;

    public interface IExportsAbstractFactory
    {
        IHM4ExportFactory CreateHM4ExportFactory();
    }
}