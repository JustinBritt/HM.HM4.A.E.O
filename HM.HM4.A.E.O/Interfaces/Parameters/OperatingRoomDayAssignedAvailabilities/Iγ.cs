namespace HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;

    public interface Iγ
    {
        ImmutableList<IγParameterElement> Value { get; }

        int GetElementAtAsint(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);
    }
}