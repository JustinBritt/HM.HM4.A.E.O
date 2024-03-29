﻿namespace HM.HM4.A.E.O.Factories.Calculations.ScenarioUnutilizedTimes
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElementCalculationFactory : IScenarioUnutilizedTimesResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElementCalculationFactory()
        {
        }

        public IScenarioUnutilizedTimesResultElementCalculation Create()
        {
            IScenarioUnutilizedTimesResultElementCalculation calculation = null;

            try
            {
                calculation = new ScenarioUnutilizedTimesResultElementCalculation();
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