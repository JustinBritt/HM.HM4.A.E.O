namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβFactory
    {
        Iβ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>> value);
    }
}