namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IHM4InputContextFactory CreateHM4InputContextFactory();

        IHM4OutputContextFactory CreateHM4OutputContextFactory();
    }
}