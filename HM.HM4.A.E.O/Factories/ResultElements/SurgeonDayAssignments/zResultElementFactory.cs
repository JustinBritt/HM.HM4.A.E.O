namespace HM.HM4.A.E.O.Factories.ResultElements.SurgeonDayAssignments
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;

    internal sealed class zResultElementFactory : IzResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public zResultElementFactory()
        {
        }

        public IzResultElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            bool value)
        {
            IzResultElement resultElement = null;

            try
            {
                resultElement = new zResultElement(
                    sIndexElement,
                    tIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}