namespace HM.HM4.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;

    public interface ISurgeonNumberAssignedOperatingRoomsResultElementCalculation
    {
        ISurgeonNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            IsIndexElement sIndexElement,
            Ix x);
    }
}