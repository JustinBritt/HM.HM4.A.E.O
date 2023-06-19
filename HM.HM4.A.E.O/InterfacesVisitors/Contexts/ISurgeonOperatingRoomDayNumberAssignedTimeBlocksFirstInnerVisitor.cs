namespace HM.HM4.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface ISurgeonOperatingRoomDayNumberAssignedTimeBlocksFirstInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Location
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>> RedBlackTree { get; }
    }
}