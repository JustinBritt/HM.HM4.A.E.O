﻿namespace HM.HM4.A.E.O.Classes.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;

    internal sealed class pParameterElement : IpParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pParameterElement(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement,
            INullableValue<decimal> value)
        {
            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;

            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}