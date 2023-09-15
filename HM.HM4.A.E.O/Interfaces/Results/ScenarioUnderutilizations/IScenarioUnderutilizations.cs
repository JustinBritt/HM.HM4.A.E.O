namespace HM.HM4.A.E.O.Interfaces.Results.ScenarioUnderutilizations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioUnderutilizations
    {
        ImmutableList<IScenarioUnderutilizationsResultElement> Value { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}