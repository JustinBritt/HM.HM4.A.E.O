namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IExpectedValueΦResultElementFactory
    {
        IExpectedValueΦResultElement Create(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}