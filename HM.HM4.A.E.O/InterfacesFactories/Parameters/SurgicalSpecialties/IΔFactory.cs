namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    public interface IΔFactory
    {
        IΔ Create(
            ImmutableList<IΔParameterElement> value);
    }
}