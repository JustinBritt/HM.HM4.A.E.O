﻿namespace HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface Iμ
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IμParameterElement>> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}