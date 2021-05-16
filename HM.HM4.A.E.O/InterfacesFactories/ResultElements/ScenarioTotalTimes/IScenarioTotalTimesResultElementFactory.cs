namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;

    public interface IScenarioTotalTimesResultElementFactory
    {
        IScenarioTotalTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}