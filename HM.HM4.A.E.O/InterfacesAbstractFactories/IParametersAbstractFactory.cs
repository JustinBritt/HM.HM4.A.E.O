namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    public interface IParametersAbstractFactory
    {
        IHFactory CreateHFactory();

        IhFactory CreatehFactory();

        ILFactory CreateLFactory();

        InFactory CreatenFactory();

        IpFactory CreatepFactory();

        IWFactory CreateWFactory();

        IyFactory CreateyFactory();

        IβFactory CreateβFactory();

        IγFactory CreateγFactory();

        IΔFactory CreateΔFactory();

        Iδ1Factory Createδ1Factory();

        Iδ2Factory Createδ2Factory();

        Iδ3Factory Createδ3Factory();

        Iδ4Factory Createδ4Factory();

        IμFactory CreateμFactory();

        IΡFactory CreateΡFactory();

        IσFactory CreateσFactory();

        IΦHatFactory CreateΦHatFactory();

        IΩFactory CreateΩFactory();
    }
}