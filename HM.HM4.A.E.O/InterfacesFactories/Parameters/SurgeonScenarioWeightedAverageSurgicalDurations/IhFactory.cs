namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;

    public interface IhFactory
    {
        Ih Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IhParameterElement>> value);
    }
}