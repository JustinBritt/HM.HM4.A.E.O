namespace HM.HM4.A.E.O.Classes.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class β : Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            ImmutableList<IβParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IβParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.rIndexElement == rIndexElement && x.dIndexElement == dIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}