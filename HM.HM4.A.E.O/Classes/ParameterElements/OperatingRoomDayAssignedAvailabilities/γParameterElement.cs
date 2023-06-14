namespace HM.HM4.A.E.O.Classes.ParameterElements.OperatingRoomDayAssignedAvailabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γParameterElement : IγParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γParameterElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            INullableValue<bool> value)
        {
            this.rIndexElement = rIndexElement;

            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public IrIndexElement rIndexElement { get; }

        public ItIndexElement tIndexElement { get; }

        public INullableValue<bool> Value { get; }
    }
}