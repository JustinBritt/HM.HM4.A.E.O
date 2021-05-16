namespace HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;

    public interface IIHatFactory
    {
        IIHat Create(
            ImmutableList<IIHatResultElement> value);
    }
}