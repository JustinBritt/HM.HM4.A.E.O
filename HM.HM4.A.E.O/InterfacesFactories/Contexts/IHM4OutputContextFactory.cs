namespace HM.HM4.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.Interfaces.Contexts;
    using HM.HM4.A.E.O.Interfaces.Models;

    public interface IHM4OutputContextFactory
    {
        IHM4OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM4Model HM4Model,
            Solution solution);
    }
}