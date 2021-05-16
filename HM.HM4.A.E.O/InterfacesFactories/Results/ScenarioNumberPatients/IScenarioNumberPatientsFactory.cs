namespace HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsFactory
    {
        IScenarioNumberPatients Create(
            ImmutableList<IScenarioNumberPatientsResultElement> value);
    }
}