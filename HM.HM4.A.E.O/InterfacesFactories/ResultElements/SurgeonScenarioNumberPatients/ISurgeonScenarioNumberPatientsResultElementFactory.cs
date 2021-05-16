namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsResultElementFactory
    {
        ISurgeonScenarioNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            int value);
    }
}