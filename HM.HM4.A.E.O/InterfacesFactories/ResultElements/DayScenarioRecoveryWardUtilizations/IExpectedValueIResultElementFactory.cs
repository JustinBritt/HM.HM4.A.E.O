namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;

    public interface IExpectedValueIResultElementFactory
    {
        IExpectedValueIResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}