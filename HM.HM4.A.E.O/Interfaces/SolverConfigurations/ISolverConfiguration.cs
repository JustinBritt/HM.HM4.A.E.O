namespace HM.HM4.A.E.O.Interfaces.SolverConfigurations
{
    using OPTANO.Modeling.Optimization;

    public interface ISolverConfiguration
    {
        SolverConfiguration Value { get; }
    }
}