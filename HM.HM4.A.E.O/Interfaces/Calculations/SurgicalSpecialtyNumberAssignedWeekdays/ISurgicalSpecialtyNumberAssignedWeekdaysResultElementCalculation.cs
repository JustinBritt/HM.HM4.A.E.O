namespace HM.HM4.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedWeekdays
{
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculation
    {
        ISurgicalSpecialtyNumberAssignedWeekdaysResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory surgicalSpecialtyNumberAssignedWeekdaysResultElementFactory,
            IΔParameterElement ΔParameterElement,
            Ix x);
    }
}