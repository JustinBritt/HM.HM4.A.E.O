namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    public interface IParameterElementsAbstractFactory
    {
        IhParameterElementFactory CreatehParameterElementFactory();

        ILParameterElementFactory CreateLParameterElementFactory();

        InParameterElementFactory CreatenParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        IyParameterElementFactory CreateyParameterElementFactory();

        IβParameterElementFactory CreateβParameterElementFactory();

        IγParameterElementFactory CreateγParameterElementFactory();

        IΔParameterElementFactory CreateΔParameterElementFactory();

        Iδ1ParameterElementFactory Createδ1ParameterElementFactory();

        Iδ2ParameterElementFactory Createδ2ParameterElementFactory();

        Iδ3ParameterElementFactory Createδ3ParameterElementFactory();

        Iδ4ParameterElementFactory Createδ4ParameterElementFactory();

        IμParameterElementFactory CreateμParameterElementFactory();

        IΡParameterElementFactory CreateΡParameterElementFactory();

        IσParameterElementFactory CreateσParameterElementFactory();

        IΦHatParameterElementFactory CreateΦHatParameterElementFactory();
    }
}