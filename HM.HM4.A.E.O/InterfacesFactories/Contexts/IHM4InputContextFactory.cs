namespace HM.HM4.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.Contexts;

    public interface IHM4InputContextFactory
    {
        IHM4InputContext Create(
            ImmutableList<INullableValue<int>> weekdays,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            ImmutableList<INullableValue<int>> lengthOfStayDays,
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
            INullableValue<int> maximumNumberRecoveryWardBeds);
    }
}