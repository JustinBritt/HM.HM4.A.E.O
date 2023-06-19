namespace HM.HM4.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor(
            IΦHatParameterElementFactory ΦHatParameterElementFactory,
            Il l,
            Is s,
            IΛ Λ)
        {
            this.ΦHatParameterElementFactory = ΦHatParameterElementFactory;

            this.l = l;

            this.s = s;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>>();
        }

        private IΦHatParameterElementFactory ΦHatParameterElementFactory { get; }

        private Il l { get; }

        private Is s { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> value = obj.Value;

            var innerVisitor = new SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                this.ΦHatParameterElementFactory,
                sIndexElement,
                this.l,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}