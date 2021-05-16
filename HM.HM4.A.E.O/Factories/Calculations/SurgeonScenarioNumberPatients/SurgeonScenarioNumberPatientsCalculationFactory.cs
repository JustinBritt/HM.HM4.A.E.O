namespace HM.HM4.A.E.O.Factories.Calculations.SurgeonScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsCalculationFactory : ISurgeonScenarioNumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsCalculationFactory()
        {
        }

        public ISurgeonScenarioNumberPatientsCalculation Create()
        {
            ISurgeonScenarioNumberPatientsCalculation calculation = null;

            try
            {
                calculation = new SurgeonScenarioNumberPatientsCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}