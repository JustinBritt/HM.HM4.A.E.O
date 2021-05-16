namespace HM.HM4.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization;

    public interface ISolverConfigurationFactory
    {
        SolverConfiguration Create<T>()
            where T : global::OPTANO.Modeling.Optimization.SolverConfiguration;
    }
}