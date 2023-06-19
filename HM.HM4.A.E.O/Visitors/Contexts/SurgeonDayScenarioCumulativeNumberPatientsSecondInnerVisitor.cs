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

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor(
            IΦHatParameterElementFactory ΦHatParameterElementFactory,
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛ Λ)
        {
            this.ΦHatParameterElementFactory = ΦHatParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IΛIndexElement, IΦHatParameterElement>();
        }

        private IΦHatParameterElementFactory ΦHatParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IlIndexElement lIndexElement { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IΛIndexElement, IΦHatParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IΛIndexElement ΛIndexElement = this.Λ.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ΛIndexElement,
                this.ΦHatParameterElementFactory.Create(
                    this.sIndexElement,
                    this.lIndexElement,
                    ΛIndexElement,
                    obj.Value));
        }
    }
}