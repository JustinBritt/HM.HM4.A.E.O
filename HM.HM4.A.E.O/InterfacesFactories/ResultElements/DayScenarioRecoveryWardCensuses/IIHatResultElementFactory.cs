namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    public interface IIHatResultElementFactory
    {
        IIHatResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}