﻿namespace HM.HM4.A.E.O.Factories.ResultElements.SurgeonNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsResultElementFactory : ISurgeonNumberAssignedOperatingRoomsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsResultElementFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElement Create(
            IsIndexElement sIndexElement,
            int value)
        {
            ISurgeonNumberAssignedOperatingRoomsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonNumberAssignedOperatingRoomsResultElement(
                    sIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}