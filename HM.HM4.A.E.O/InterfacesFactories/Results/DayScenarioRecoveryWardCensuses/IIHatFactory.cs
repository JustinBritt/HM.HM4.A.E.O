namespace HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;

    public interface IIHatFactory
    {
        IIHat Create(
            RedBlackTree<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>> value);
    }
}