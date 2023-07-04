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

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor(
            IΦHatParameterElementFactory ΦHatParameterElementFactory,
            IsIndexElement sIndexElement,
            Il l,
            IΛ Λ)
        {
            this.ΦHatParameterElementFactory = ΦHatParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.l = l;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>();
        }

        private IΦHatParameterElementFactory ΦHatParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private Il l { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IlIndexElement lIndexElement = this.l.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            ISurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<INullableValue<int>, INullableValue<decimal>> innerVisitor = new SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.ΦHatParameterElementFactory,
                this.sIndexElement,
                lIndexElement,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                lIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}