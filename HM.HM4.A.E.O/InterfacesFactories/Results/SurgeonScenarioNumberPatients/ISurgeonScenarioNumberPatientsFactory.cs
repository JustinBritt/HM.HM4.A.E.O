namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsFactory
    {
        ISurgeonScenarioNumberPatients Create(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value);
    }
}