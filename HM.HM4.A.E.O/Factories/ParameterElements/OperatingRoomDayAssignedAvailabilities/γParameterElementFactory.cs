namespace HM.HM4.A.E.O.Factories.ParameterElements.OperatingRoomDayAssignedAvailabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Classes.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γParameterElementFactory : IγParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γParameterElementFactory()
        {
        }

        public IγParameterElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            FhirBoolean value)
        {
            IγParameterElement parameterElement = null;

            try
            {
                parameterElement = new γParameterElement(
                    rIndexElement,
                    tIndexElement,
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