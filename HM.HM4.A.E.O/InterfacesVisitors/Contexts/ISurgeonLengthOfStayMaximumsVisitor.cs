namespace HM.HM4.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;

    public interface ISurgeonLengthOfStayMaximumsVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
    {
        RedBlackTree<IsIndexElement, ILParameterElement> RedBlackTree { get; }
    }
}