﻿namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;

    public interface IσFactory
    {
        Iσ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IσParameterElement>> value);
    }
}