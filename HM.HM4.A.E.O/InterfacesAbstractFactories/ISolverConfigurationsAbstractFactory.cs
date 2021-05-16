namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.SolverConfigurations;

    public interface ISolverConfigurationsAbstractFactory
    {
        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}