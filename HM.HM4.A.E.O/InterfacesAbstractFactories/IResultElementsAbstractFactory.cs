namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface IResultElementsAbstractFactory
    {
        IEBSResultElementFactory CreateEBSResultElementFactory();

        IExpectedValueIResultElementFactory CreateExpectedValueIResultElementFactory();

        IExpectedValueΦResultElementFactory CreateExpectedValueΦResultElementFactory();

        IIHatResultElementFactory CreateIHatResultElementFactory();

        IScenarioNumberPatientsResultElementFactory CreateScenarioNumberPatientsResultElementFactory();

        IScenarioTotalTimesResultElementFactory CreateScenarioTotalTimesResultElementFactory();

        IScenarioUnderutilizationsResultElementFactory CreateScenarioUnderutilizationsResultElementFactory();

        IScenarioUnutilizedTimesResultElementFactory CreateScenarioUnutilizedTimesResultElementFactory();

        IScenarioUtilizedTimesResultElementFactory CreateScenarioUtilizedTimesResultElementFactory();

        IS1ResultElementFactory CreateS1ResultElementFactory();

        IS2ResultElementFactory CreateS2ResultElementFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory();

        ISurgeonNumberAssignedWeekdaysResultElementFactory CreateSurgeonNumberAssignedWeekdaysResultElementFactory();

        ISurgeonScenarioNumberPatientsResultElementFactory CreateSurgeonScenarioNumberPatientsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory();

        ITEBSResultElementFactory CreateTEBSΛResultElementFactory();

        IVarianceIResultElementFactory CreateVarianceIResultElementFactory();

        IVarianceΦResultElementFactory CreateVarianceΦResultElementFactory();

        IxResultElementFactory CreatexResultElementFactory();

        IzResultElementFactory CreatezResultElementFactory();
    }
}