namespace HM.HM4.A.E.O.Factories.Results.DayScenarioRecoveryWardUtilizations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;

    internal sealed class ExpectedValueIFactory : IExpectedValueIFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueIFactory()
        {
        }

        public IExpectedValueI Create(
            ImmutableList<IExpectedValueIResultElement> value)
        {
            IExpectedValueI result = null;

            try
            {
                result = new ExpectedValueI(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}