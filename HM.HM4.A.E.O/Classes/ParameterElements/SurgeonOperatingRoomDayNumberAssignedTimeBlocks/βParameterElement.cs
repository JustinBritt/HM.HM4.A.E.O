namespace HM.HM4.A.E.O.Classes.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class βParameterElement : IβParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βParameterElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            PositiveInt value)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.dIndexElement = dIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public PositiveInt Value { get; }
    }
}