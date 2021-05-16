namespace HM.HM4.A.E.O.Factories.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Classes.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    internal sealed class σParameterElementFactory : IσParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public σParameterElementFactory()
        {
        }

        public IσParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            FhirDecimal value)
        {
            IσParameterElement parameterElement = null;

            try
            {
                parameterElement = new σParameterElement(
                    sIndexElement,
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}