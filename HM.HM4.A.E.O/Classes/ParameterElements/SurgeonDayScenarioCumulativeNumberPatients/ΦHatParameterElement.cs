namespace HM.HM4.A.E.O.Classes.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHatParameterElement : IΦHatParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHatParameterElement(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            FhirDecimal value)
        {
            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}