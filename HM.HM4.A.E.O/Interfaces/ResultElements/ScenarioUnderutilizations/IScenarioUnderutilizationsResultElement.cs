namespace HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnderutilizationsResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}