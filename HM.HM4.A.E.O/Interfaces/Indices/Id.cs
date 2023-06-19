namespace HM.HM4.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface Id
    {
        RedBlackTree<INullableValue<int>, IdIndexElement> Value { get; }

        IdIndexElement GetElementAt(
            INullableValue<int> value);
    }
}