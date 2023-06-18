namespace HM.HM4.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM4InputContext
    {
        ImmutableSortedSet<INullableValue<int>> Weekdays { get; }

        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        Duration TimeBlockLength { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonLengthOfStayMaximums { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        INullableValue<int> NumberDaysPerWeek { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<int>, INullableValue<int>>> SurgeonOperatingRoomDayNumberAssignedTimeBlocks { get; }

        ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> OperatingRoomDayAssignedAvailabilities { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientMeans { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientStandardDeviations { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        INullableValue<int> MaximumNumberRecoveryWardBeds { get; }
    }
}