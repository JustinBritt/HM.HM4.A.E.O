namespace HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioTotalExpectedBedShortages
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface ITEBSResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}