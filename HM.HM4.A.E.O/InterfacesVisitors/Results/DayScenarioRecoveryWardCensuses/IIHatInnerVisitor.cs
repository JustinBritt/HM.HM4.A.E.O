namespace HM.HM4.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    public interface IIHatInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IΛIndexElement
        where TValue : IIHatResultElement
    {
        RedBlackTree<INullableValue<int>, INullableValue<decimal>> RedBlackTree { get; }
    }
}