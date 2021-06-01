namespace HM.HM4.A.E.O.Factories.ResultElements.SurgeonScenarioNumberPatients
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementFactory : ISurgeonScenarioNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementFactory()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            int value)
        {
            ISurgeonScenarioNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonScenarioNumberPatientsResultElement(
                    sIndexElement,
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