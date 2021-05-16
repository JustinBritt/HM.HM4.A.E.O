namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsResultElementFactory
    {
        IScenarioUnderutilizationsResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}