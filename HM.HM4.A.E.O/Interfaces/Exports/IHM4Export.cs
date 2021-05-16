namespace HM.HM4.A.E.O.Interfaces.Exports
{
    using System.Threading.Tasks;

    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.Interfaces.Configurations;
    using HM.HM4.A.E.O.Interfaces.Contexts;
    using HM.HM4.A.E.O.Interfaces.SolverConfigurations;

    public interface IHM4Export
    {
        Task<IHM4OutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM4Configuration HM4Configuration,
            IHM4InputContext HM4InputContext,
            ISolverConfiguration solverConfiguration);
    }
}