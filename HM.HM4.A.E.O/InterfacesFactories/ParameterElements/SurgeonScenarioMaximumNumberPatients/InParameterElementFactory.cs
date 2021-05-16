namespace HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface InParameterElementFactory
    {
        InParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            PositiveInt value);
    }
}