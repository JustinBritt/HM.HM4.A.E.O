namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Configurations;

    public interface IConfigurationsAbstractFactory
    {
        IHM4ConfigurationFactory CreateHM4ConfigurationFactory();
    }
}