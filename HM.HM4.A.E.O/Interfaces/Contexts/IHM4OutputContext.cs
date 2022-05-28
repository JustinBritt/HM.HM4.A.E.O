﻿namespace HM.HM4.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface IHM4OutputContext
    {
        INullableValue<decimal> BestBound { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioExpectedBedShortages { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationExpectedValues { get; }

        INullableValue<decimal> Gap { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Location> S1 { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<int>>> ScenarioNumberPatients { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioTotalTimes { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUnderutilizations { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUnutilizedTimes { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUtilizedTimes { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedWeekdays { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedWeekdays { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioTotalExpectedBedShortages { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationVariances { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> SurgeonOperatingRoomDayAssignments { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<bool>>> SurgeonDayAssignments { get; }
    }
}