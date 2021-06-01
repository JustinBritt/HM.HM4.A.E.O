namespace HM.HM4.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xResultElementFactory : IxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xResultElementFactory()
        {
        }

        public IxResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            IxResultElement resultElement = null;

            try
            {
                resultElement = new xResultElement(
                    sIndexElement,
                    rIndexElement,
                    tIndexElement,
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