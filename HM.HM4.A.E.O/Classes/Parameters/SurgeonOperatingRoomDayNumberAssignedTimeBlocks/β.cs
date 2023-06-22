namespace HM.HM4.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class β : Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value[sIndexElement][rIndexElement][dIndexElement].Value.Value.Value;
        }
    }
}