namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;

    public interface IxFactory
    {
        Ix Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> redBlackTree,
            ImmutableList<IxResultElement> value);
    }
}