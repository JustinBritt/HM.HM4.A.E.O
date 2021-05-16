namespace HM.HM4.A.E.O.Interfaces.Results.SurgeonDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iz
    {
        ImmutableList<IzResultElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}