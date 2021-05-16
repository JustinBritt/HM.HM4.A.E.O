namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesResultElementFactory
    {
        IScenarioUtilizedTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}