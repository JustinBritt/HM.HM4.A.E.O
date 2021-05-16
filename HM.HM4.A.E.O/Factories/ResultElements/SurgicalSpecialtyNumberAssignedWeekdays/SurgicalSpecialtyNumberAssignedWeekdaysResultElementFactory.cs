namespace HM.HM4.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory : ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Create(
            IjIndexElement jIndexElement,
            int value)
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElement resultElement = null;

            try
            {
                resultElement = new SurgicalSpecialtyNumberAssignedWeekdaysResultElement(
                    jIndexElement,
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