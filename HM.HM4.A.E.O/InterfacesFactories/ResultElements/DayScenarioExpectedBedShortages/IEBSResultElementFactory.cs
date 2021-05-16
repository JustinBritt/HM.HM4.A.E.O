namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;

    public interface IEBSResultElementFactory
    {
        IEBSResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}