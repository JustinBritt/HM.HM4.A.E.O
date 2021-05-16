namespace HM.HM4.A.E.O.Factories.Results.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IHatFactory : IIHatFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHatFactory()
        {
        }

        public IIHat Create(
            ImmutableList<IIHatResultElement> value)
        {
            IIHat result = null;

            try
            {
                result = new IHat(
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