namespace HM.HM4.A.E.O.Classes.ResultElements.DayScenarioRecoveryWardCensuses
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    internal sealed class IHatResultElement : IIHatResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHatResultElement(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            decimal value)
        {
            this.tIndexElement = tIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public ItIndexElement tIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public decimal Value { get; }
    }
}