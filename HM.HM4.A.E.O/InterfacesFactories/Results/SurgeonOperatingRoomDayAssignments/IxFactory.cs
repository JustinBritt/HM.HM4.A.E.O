namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;

    public interface IxFactory
    {
        Ix Create(
            ImmutableList<IxResultElement> value);
    }
}