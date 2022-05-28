namespace HM.HM4.A.E.O.Interfaces.Calculations.Sets
{
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.Results.Sets;

    public interface IS1Calculation
    {
        IS1 Calculate(
            IS1ResultElementFactory S1ResultElementFactory,
            IS1Factory S1Factory,
            Ir r,
            Ix x,
            IΔ Δ);
    }
}