namespace HM.HM4.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;

    public interface IOperatingRoomDayAssignedAvailabilitiesOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Location
        where TValue : RedBlackTree<FhirDateTime, INullableValue<bool>>
    {
        RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> RedBlackTree { get; }
    }
}