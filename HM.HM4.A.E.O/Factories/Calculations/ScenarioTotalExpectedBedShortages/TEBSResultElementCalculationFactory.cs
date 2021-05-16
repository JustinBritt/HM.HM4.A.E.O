namespace HM.HM4.A.E.O.Factories.Calculations.ScenarioTotalExpectedBedShortages
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM4.A.E.O.Interfaces.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;

    internal sealed class TEBSResultElementCalculationFactory : ITEBSResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSResultElementCalculationFactory()
        {
        }

        public ITEBSResultElementCalculation Create()
        {
            ITEBSResultElementCalculation calculation = null;

            try
            {
                calculation = new TEBSResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}