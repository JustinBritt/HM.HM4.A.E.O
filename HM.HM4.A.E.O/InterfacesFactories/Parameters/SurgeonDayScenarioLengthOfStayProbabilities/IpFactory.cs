namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;

    public interface IpFactory
    {
        Ip Create(
            ImmutableList<IpParameterElement> value);
    }
}