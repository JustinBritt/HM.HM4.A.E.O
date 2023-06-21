namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;

    public interface IγFactory
    {
        Iγ Create(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> value);
    }
}