namespace HM.HM4.A.E.O.Factories.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Parameters.OperatingRoomDayAssignedAvailabilities;
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
            ImmutableList<IγParameterElement> value)
        {
            Iγ parameter = null;

            try
            {
                parameter = new γ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}