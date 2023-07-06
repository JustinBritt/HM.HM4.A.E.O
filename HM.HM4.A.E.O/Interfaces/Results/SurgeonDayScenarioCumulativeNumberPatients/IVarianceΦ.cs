﻿namespace HM.HM4.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IVarianceΦ
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IVarianceΦResultElement>>> Value { get; }

        decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement);
    }
}