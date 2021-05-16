namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages;

    public interface ITEBSResultElementFactory
    {
        ITEBSResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}