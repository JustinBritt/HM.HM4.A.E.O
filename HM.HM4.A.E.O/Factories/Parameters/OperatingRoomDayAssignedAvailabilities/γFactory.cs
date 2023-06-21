namespace HM.HM4.A.E.O.Factories.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Classes.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γFactory : IγFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γFactory()
        {
        }

        public Iγ Create(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> value)
        {
            Iγ parameter = null;

            try
            {
                parameter = new γ(
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