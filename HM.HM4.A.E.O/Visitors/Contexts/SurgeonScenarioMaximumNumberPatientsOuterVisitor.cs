﻿namespace HM.HM4.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioMaximumNumberPatientsOuterVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientsOuterVisitor(
            InParameterElementFactory nParameterElementFactory,
            Is s,
            IΛ Λ)
        {
            this.nParameterElementFactory = nParameterElementFactory;

            this.s = s;

            this.Λ = Λ;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>>();
        }

        private InParameterElementFactory nParameterElementFactory { get; }

        private Is s { get; }

        private IΛ Λ { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, InParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<int>> value = obj.Value;

            ISurgeonScenarioMaximumNumberPatientsInnerVisitor<INullableValue<int>, INullableValue<int>> innerVisitor = new SurgeonScenarioMaximumNumberPatientsInnerVisitor<INullableValue<int>, INullableValue<int>>(
                this.nParameterElementFactory,
                sIndexElement,
                this.Λ);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}