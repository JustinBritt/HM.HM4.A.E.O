namespace HM.HM4.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM4.A.E.O.Interfaces.Configurations;

    public interface IHM4ConfigurationFactory
    {
        IHM4Configuration Create(
            Configuration configuration);
    }
}