namespace HM.HM4.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;

    public interface IExpectedValueICalculation
    {
        IExpectedValueI Calculate(
            IExpectedValueIResultElementFactory expectedValueIResultElementFactory,
            IExpectedValueIFactory expectedValueIFactory,
            IExpectedValueIResultElementCalculation expectedValueIResultElementCalculation,
            Il l,
            It t,
            Ist st,
            ItΛ tΛ,
            IExpectedValueΦ expectedValueΦ,
            Iz z);
    }
}