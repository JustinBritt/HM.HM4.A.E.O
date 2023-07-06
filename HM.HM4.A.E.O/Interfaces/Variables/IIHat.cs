namespace HM.HM4.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    public interface IIHat
    {
        VariableCollection<ItIndexElement, IΛIndexElement> Value { get; }

        decimal GetElementAt(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement);

        Interfaces.Results.DayScenarioRecoveryWardCensuses.IIHat GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIHatResultElementFactory IHatResultElementFactory,
            IIHatFactory IHatFactory,
            It t,
            IΛ Λ);
    }
}