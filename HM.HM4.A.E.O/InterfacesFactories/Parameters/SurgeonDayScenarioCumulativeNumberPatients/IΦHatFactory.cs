namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IΦHatFactory
    {
        IΦHat Create(
            ImmutableList<IΦHatParameterElement> value);
    }
}