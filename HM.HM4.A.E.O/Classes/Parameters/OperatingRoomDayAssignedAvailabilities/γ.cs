namespace HM.HM4.A.E.O.Classes.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value[rIndexElement][tIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}