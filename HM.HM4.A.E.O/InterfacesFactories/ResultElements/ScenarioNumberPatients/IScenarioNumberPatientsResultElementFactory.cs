namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementFactory
    {
        IScenarioNumberPatientsResultElement Create(
            IΛIndexElement ΛIndexElement,
            int value);
    }
}