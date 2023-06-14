namespace HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;

    public interface ILParameterElementFactory
    {
        ILParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value);
    }
}