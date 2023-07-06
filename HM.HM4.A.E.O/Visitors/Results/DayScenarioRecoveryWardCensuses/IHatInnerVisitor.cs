namespace HM.HM4.A.E.O.Visitors.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.Comparers;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM4.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IHatInnerVisitor<TKey, TValue> : IIHatInnerVisitor<TKey, TValue>
        where TKey : IΛIndexElement
        where TValue : IIHatResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHatInnerVisitor(
            INullableValueFactory nullableValueFactory,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<decimal>>(
                nullableValueintComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<decimal>(
                    obj.Value.Value));
        }
    }
}