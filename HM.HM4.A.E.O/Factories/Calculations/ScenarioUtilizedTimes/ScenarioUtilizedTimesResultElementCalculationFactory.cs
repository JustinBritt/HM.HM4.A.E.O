﻿namespace HM.HM4.A.E.O.Factories.Calculations.ScenarioUtilizedTimes
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesResultElementCalculationFactory : IScenarioUtilizedTimesResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesResultElementCalculationFactory()
        {
        }

        public IScenarioUtilizedTimesResultElementCalculation Create()
        {
            IScenarioUtilizedTimesResultElementCalculation calculation = null;

            try
            {
                calculation = new ScenarioUtilizedTimesResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}