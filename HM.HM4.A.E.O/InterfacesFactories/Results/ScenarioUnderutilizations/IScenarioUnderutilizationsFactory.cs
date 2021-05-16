namespace HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsFactory
    {
        IScenarioUnderutilizations Create(
            ImmutableList<IScenarioUnderutilizationsResultElement> value);
    }
}