namespace HM.HM4.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IScenarioProbabilitiesVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
    {
        RedBlackTree<IΛIndexElement, IΡParameterElement> RedBlackTree { get; }
    }
}