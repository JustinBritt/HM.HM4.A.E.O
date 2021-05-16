namespace HM.HM4.A.E.O.Classes.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            ImmutableList<IγParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IγParameterElement> Value { get; }

        public int GetElementAtAsint(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(x => x.rIndexElement == rIndexElement && x.tIndexElement == tIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}