namespace HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IScenarioNumberPatientsResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        int Value { get; }
    }
}