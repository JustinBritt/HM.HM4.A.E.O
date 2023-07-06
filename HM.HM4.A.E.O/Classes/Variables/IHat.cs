namespace HM.HM4.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IHat : IIHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHat(
            VariableCollection<ItIndexElement, IΛIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<ItIndexElement, IΛIndexElement> Value { get; }

        public decimal GetElementAt(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return (decimal)this.Value[tIndexElement, ΛIndexElement].Value;
        }

        public Interfaces.Results.DayScenarioRecoveryWardCensuses.IIHat GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIHatResultElementFactory IHatResultElementFactory,
            IIHatFactory IHatFactory,
            It t,
            IΛ Λ)
        {
            RedBlackTree<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>>();

            foreach (ItIndexElement tIndexElement in t.Value.Values)
            {
                RedBlackTree<IΛIndexElement, IIHatResultElement> innerRedBlackTree = redBlackTreeFactory.Create<IΛIndexElement, IIHatResultElement>();

                foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ΛIndexElement,
                        IHatResultElementFactory.Create(
                            tIndexElement,
                            ΛIndexElement,
                            this.GetElementAt(
                                tIndexElement,
                                ΛIndexElement)));
                }

                outerRedBlackTree.Add(
                    tIndexElement,
                    innerRedBlackTree);
            }

            return IHatFactory.Create(
                outerRedBlackTree);
        }
    }
}