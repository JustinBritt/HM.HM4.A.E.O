namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IΦHatFactory
    {
        IΦHat Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>> value);
    }
}