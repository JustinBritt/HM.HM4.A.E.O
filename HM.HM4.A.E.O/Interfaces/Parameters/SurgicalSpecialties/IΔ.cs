namespace HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface IΔ
    {
        ImmutableList<IΔParameterElement> Value { get; }

        IjIndexElement GetSurgicalSpecialtyOfSurgeon(
            IsIndexElement sIndexElement);

        bool IsSurgeonMemberOfSurgicalSpecialty(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement);
    }
}