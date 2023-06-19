namespace HM.HM4.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    public interface ISurgeonScenarioMaximumNumberPatientMeansInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
    {
        RedBlackTree<IΛIndexElement, IμParameterElement> RedBlackTree { get; }
    }
}