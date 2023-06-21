namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;

    public interface IyFactory
    {
        Iy Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyParameterElement>> value);
    }
}