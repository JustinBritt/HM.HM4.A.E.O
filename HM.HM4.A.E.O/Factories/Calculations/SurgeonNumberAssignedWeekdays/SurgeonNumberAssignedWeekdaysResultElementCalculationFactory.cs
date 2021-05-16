namespace HM.HM4.A.E.O.Factories.Calculations.SurgeonNumberAssignedWeekdays
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysResultElementCalculationFactory : ISurgeonNumberAssignedWeekdaysResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysResultElementCalculationFactory()
        {
        }

        public ISurgeonNumberAssignedWeekdaysResultElementCalculation Create()
        {
            ISurgeonNumberAssignedWeekdaysResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonNumberAssignedWeekdaysResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}