namespace HM.HM4.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardUtilizations
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;

    internal sealed class ExpectedValueIResultElementFactory : IExpectedValueIResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueIResultElementFactory()
        {
        }

        public IExpectedValueIResultElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            IExpectedValueIResultElement resultElement = null;

            try
            {
                resultElement = new ExpectedValueIResultElement(
                    tIndexElement,
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