namespace HM.HM4.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM4InputContext
    {
        ImmutableSortedSet<INullableValue<int>> Weekdays { get; }

        RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        Duration TimeBlockLength { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonLengthOfStayMaximums { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        INullableValue<int> NumberDaysPerWeek { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>> SurgeonOperatingRoomDayNumberAssignedTimeBlocks { get; }

        RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> OperatingRoomDayAssignedAvailabilities { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientMeans { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMaximumNumberPatientStandardDeviations { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        INullableValue<int> MaximumNumberRecoveryWardBeds { get; }
    }
}