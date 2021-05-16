namespace HM.HM4.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IlIndexElementFactory
    {
        IlIndexElement Create(
            PositiveInt value);
    }
}