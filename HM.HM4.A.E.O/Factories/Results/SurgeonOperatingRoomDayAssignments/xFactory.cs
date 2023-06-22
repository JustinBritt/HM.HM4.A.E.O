namespace HM.HM4.A.E.O.Factories.Results.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
   
    internal sealed class xFactory : IxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFactory()
        {
        }

        public Ix Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> redBlackTree,
            ImmutableList<IxResultElement> value)
        {
            Ix result = null;

            try
            {
                result = new x(
                    redBlackTree,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}