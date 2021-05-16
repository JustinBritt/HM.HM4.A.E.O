namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface IβFactory
    {
        Iβ Create(
            ImmutableList<IβParameterElement> value);
    }
}