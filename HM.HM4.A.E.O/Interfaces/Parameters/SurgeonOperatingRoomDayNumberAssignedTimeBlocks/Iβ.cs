namespace HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface Iβ
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement);
    }
}