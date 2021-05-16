namespace HM.HM4.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IExpectedValueΦCalculation
    {
        IExpectedValueΦ Calculate(
            IExpectedValueΦResultElementFactory expectedValueΦResultElementFactory,
            IExpectedValueΦFactory expectedValueΦFactory,
            IExpectedValueΦResultElementCalculation expectedValueΦResultElementCalculation,
            Il l,
            It t,
            IslΛ slΛ,
            IL L,
            Ip p,
            Iμ μ);
    }
}