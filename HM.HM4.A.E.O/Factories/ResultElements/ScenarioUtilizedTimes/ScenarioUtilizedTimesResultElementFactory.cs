namespace HM.HM4.A.E.O.Factories.ResultElements.ScenarioUtilizedTimes
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesResultElementFactory : IScenarioUtilizedTimesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesResultElementFactory()
        {
        }

        public IScenarioUtilizedTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IScenarioUtilizedTimesResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioUtilizedTimesResultElement(
                    ΛIndexElement,
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