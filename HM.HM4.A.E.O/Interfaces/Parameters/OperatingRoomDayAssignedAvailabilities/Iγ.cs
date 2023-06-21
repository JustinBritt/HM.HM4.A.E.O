namespace HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;

    public interface Iγ
    {
        RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> Value { get; }

        int GetElementAtAsint(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);
    }
}