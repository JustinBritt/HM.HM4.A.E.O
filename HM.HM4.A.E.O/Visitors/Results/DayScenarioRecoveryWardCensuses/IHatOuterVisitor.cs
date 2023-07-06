namespace HM.HM4.A.E.O.Visitors.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.Comparers;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM4.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IHatOuterVisitor<TKey, TValue> : IIHatOuterVisitor<TKey, TValue>
        where TKey : ItIndexElement
        where TValue : RedBlackTree<IΛIndexElement, IIHatResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHatOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = new RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                FhirDateTimeComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ItIndexElement tIndexElement = obj.Key;

            RedBlackTree<IΛIndexElement, IIHatResultElement> value = obj.Value;

            IIHatInnerVisitor<IΛIndexElement, IIHatResultElement> innerVisitor = new IHatInnerVisitor<IΛIndexElement, IIHatResultElement>(
                this.NullableValueFactory,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                tIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}