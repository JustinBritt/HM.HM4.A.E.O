namespace HM.HM4.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Classes.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class βParameterElementFactory : IβParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βParameterElementFactory()
        {
        }

        public IβParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            PositiveInt value)
        {
            IβParameterElement parameterElement = null;

            try
            {
                parameterElement = new βParameterElement(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}