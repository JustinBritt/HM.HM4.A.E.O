namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;

    public interface IpFactory
    {
        Ip Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IpParameterElement>>> value);
    }
}