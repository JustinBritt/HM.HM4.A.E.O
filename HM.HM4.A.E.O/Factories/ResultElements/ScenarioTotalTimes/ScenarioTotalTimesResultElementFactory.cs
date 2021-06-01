namespace HM.HM4.A.E.O.Factories.ResultElements.ScenarioTotalTimes
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.ScenarioTotalTimes;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElementFactory : IScenarioTotalTimesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElementFactory()
        {
        }

        public IScenarioTotalTimesResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IScenarioTotalTimesResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioTotalTimesResultElement(
                    ΛIndexElement,
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