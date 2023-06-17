namespace HM.HM4.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.Contexts;

    public sealed class HM4InputContext : IHM4InputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4InputContext(
            ImmutableSortedSet<INullableValue<int>> weekdays,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            Bundle operatingRooms,
            Bundle surgeons,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<INullableValue<int>> scenarios,
            Duration timeBlockLength,
            ImmutableList<Tuple<Organization, INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonLengthOfStayMaximums,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioLengthOfStayProbabilities,
            INullableValue<int> numberDaysPerWeek,
            ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> surgeonOperatingRoomAssignments,
            ImmutableList<Tuple<Organization, Location, INullableValue<int>, INullableValue<int>>> surgeonOperatingRoomDayNumberAssignedTimeBlocks,
            ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> operatingRoomDayAssignedAvailabilities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeans,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviations,
            ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> surgeonDayScenarioCumulativeNumberPatients,
            INullableValue<int> maximumNumberRecoveryWardBeds)
        {
            this.Weekdays = weekdays;

            this.SurgicalSpecialties = surgicalSpecialties;

            this.LengthOfStayDays = lengthOfStayDays;

            this.OperatingRooms = operatingRooms;

            this.Surgeons = surgeons;

            this.PlanningHorizon = planningHorizon;

            this.Scenarios = scenarios;

            this.TimeBlockLength = timeBlockLength;

            this.SurgeonScenarioWeightedAverageSurgicalDurations = surgeonScenarioWeightedAverageSurgicalDurations;

            this.SurgeonLengthOfStayMaximums = surgeonLengthOfStayMaximums;

            this.SurgeonScenarioMaximumNumberPatients = surgeonScenarioMaximumNumberPatients;

            this.SurgeonDayScenarioLengthOfStayProbabilities = surgeonDayScenarioLengthOfStayProbabilities;

            this.NumberDaysPerWeek = numberDaysPerWeek;

            this.SurgeonOperatingRoomAssignments = surgeonOperatingRoomAssignments;

            this.SurgeonOperatingRoomDayNumberAssignedTimeBlocks = surgeonOperatingRoomDayNumberAssignedTimeBlocks;

            this.OperatingRoomDayAssignedAvailabilities = operatingRoomDayAssignedAvailabilities;

            this.SurgeonScenarioMaximumNumberPatientMeans = surgeonScenarioMaximumNumberPatientMeans;

            this.ScenarioProbabilities = scenarioProbabilities;

            this.SurgeonScenarioMaximumNumberPatientStandardDeviations = surgeonScenarioMaximumNumberPatientStandardDeviations;

            this.SurgeonDayScenarioCumulativeNumberPatients = surgeonDayScenarioCumulativeNumberPatients;

            this.MaximumNumberRecoveryWardBeds = maximumNumberRecoveryWardBeds;
        }

        public ImmutableSortedSet<INullableValue<int>> Weekdays { get; }

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        public Bundle OperatingRooms { get; }

        public Bundle Surgeons { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        public ImmutableList<INullableValue<int>> Scenarios { get; }

        public Duration TimeBlockLength { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonLengthOfStayMaximums { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        public INullableValue<int> NumberDaysPerWeek { get; }

        public ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        public ImmutableList<Tuple<Organization, Location, INullableValue<int>, INullableValue<int>>> SurgeonOperatingRoomDayNumberAssignedTimeBlocks { get; }

        public ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> OperatingRoomDayAssignedAvailabilities { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientMeans { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<decimal>>> ScenarioProbabilities { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientStandardDeviations { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        public INullableValue<int> MaximumNumberRecoveryWardBeds { get; }
    }
}