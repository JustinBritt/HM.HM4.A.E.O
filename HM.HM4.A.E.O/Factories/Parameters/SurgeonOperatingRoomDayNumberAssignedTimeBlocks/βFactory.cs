namespace HM.HM4.A.E.O.Factories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class βFactory : IβFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βFactory()
        {
        }

        public Iβ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>> value)
        {
            Iβ parameter = null;

            try
            {
                parameter = new β(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}