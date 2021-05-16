namespace HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    public interface IIHatResultElement
    {
        ItIndexElement tIndexElement { get; }

        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}