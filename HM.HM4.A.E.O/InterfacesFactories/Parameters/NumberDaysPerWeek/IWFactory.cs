namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;

    public interface IWFactory
    {
        IW Create(
            PositiveInt value);
    }
}