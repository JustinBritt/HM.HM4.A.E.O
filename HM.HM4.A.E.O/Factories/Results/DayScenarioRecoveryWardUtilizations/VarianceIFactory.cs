namespace HM.HM4.A.E.O.Factories.Results.DayScenarioRecoveryWardUtilizations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;

    internal sealed class VarianceIFactory : IVarianceIFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceIFactory()
        {
        }

        public IVarianceI Create(
            ImmutableList<IVarianceIResultElement> value)
        {
            IVarianceI result = null;

            try
            {
                result = new VarianceI(
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