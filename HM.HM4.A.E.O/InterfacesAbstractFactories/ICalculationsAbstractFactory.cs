namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.TimeBlocks;

    public interface ICalculationsAbstractFactory
    {
        IEBSCalculationFactory CreateEBSCalculationFactory();

        IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory();

        IExpectedValueICalculationFactory CreateExpectedValueICalculationFactory();

        IExpectedValueIResultElementCalculationFactory CreateExpectedValueIResultElementCalculationFactory();

        IExpectedValueΦCalculationFactory CreateExpectedValueΦCalculationFactory();

        IExpectedValueΦResultElementCalculationFactory CreateExpectedValueΦResultElementCalculationFactory();

        IScenarioNumberPatientsCalculationFactory CreateScenarioNumberPatientsCalculationFactory();

        IScenarioNumberPatientsResultElementCalculationFactory CreateScenarioNumberPatientsResultElementCalculationFactory();

        IScenarioTotalTimesCalculationFactory CreateScenarioTotalTimesCalculationFactory();

        IScenarioTotalTimesResultElementCalculationFactory CreateScenarioTotalTimesResultElementCalculationFactory();

        IScenarioUnderutilizationsCalculationFactory CreateScenarioUnderutilizationsCalculationFactory();

        IScenarioUnderutilizationsResultElementCalculationFactory CreateScenarioUnderutilizationsResultElementCalculationFactory();

        IScenarioUnutilizedTimesCalculationFactory CreateScenarioUnutilizedTimesCalculationFactory();

        IScenarioUnutilizedTimesResultElementCalculationFactory CreateScenarioUnutilizedTimesResultElementCalculationFactory();

        IScenarioUtilizedTimesCalculationFactory CreateScenarioUtilizedTimesCalculationFactory();

        IScenarioUtilizedTimesResultElementCalculationFactory CreateScenarioUtilizedTimesResultElementCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgeonNumberAssignedWeekdaysCalculationFactory CreateSurgeonNumberAssignedWeekdaysCalculationFactory();

        ISurgeonNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory();

        ISurgeonScenarioNumberPatientsCalculationFactory CreateSurgeonScenarioNumberPatientsCalculationFactory();

        ISurgeonScenarioNumberPatientsResultElementCalculationFactory CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory();

        HM.HM4.A.E.O.InterfacesFactories.Calculations.TotalExpectedBedShortage.ITEBSCalculationFactory CreateTEBSCalculationFactory();

        HM.HM4.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages.ITEBSCalculationFactory CreateTEBSΛCalculationFactory();

        ITEBSResultElementCalculationFactory CreateTEBSΛResultElementCalculationFactory();

        IVarianceICalculationFactory CreateVarianceICalculationFactory();

        IVarianceIResultElementCalculationFactory CreateVarianceIResultElementCalculationFactory();

        IVarianceΦCalculationFactory CreateVarianceΦCalculationFactory();

        IVarianceΦResultElementCalculationFactory CreateVarianceΦResultElementCalculationFactory();

        Iδ1CalculationFactory Createδ1CalculationFactory();

        Iδ1ParameterElementCalculationFactory Createδ1ParameterElementCalculationFactory();

        Iδ2CalculationFactory Createδ2CalculationFactory();

        Iδ2ParameterElementCalculationFactory Createδ2ParameterElementCalculationFactory();

        Iδ3CalculationFactory Createδ3CalculationFactory();

        Iδ3ParameterElementCalculationFactory Createδ3ParameterElementCalculationFactory();

        Iδ4CalculationFactory Createδ4CalculationFactory();

        Iδ4ParameterElementCalculationFactory Createδ4ParameterElementCalculationFactory();
    }
}