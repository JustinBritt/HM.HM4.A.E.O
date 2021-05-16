namespace HM.HM4.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculation
    {
        ISurgicalSpecialtyNumberAssignedOperatingRooms Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory surgicalSpecialtyNumberAssignedOperatingRoomsFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation,
            IΔ Δ,
            Ix x);
    }
}