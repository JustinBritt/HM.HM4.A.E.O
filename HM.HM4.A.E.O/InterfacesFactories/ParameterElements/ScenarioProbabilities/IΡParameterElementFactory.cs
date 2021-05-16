namespace HM.HM4.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IΡParameterElementFactory
    {
        IΡParameterElement Create(
            IΛIndexElement ΛIndexElement,
            FhirDecimal value);
    }
}