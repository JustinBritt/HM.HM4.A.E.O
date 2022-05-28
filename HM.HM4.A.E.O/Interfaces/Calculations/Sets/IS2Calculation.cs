namespace HM.HM4.A.E.O.Interfaces.Calculations.Sets
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.Results.Sets;

    public interface IS2Calculation
    {
        IS2 Calculate(
            IS2ResultElementFactory S2ResultElementFactory,
            IS2Factory S2Factory,
            Id d1,
            Id d2,
            Ir r,
            It t,
            Irdd rdd,
            IW W,
            IΔ Δ,
            Ix x);
    }
}