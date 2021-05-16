namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds
{
    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;

    public interface IΩFactory
    {
        IΩ Create(
            PositiveInt value);
    }
}