namespace HM.HM4.A.E.O.Factories.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;

    internal sealed class VarianceIResultElementCalculationFactory : IVarianceIResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceIResultElementCalculationFactory()
        {
        }

        public IVarianceIResultElementCalculation Create()
        {
            IVarianceIResultElementCalculation calculation = null;

            try
            {
                calculation = new VarianceIResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}