namespace HM.HM4.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IExpectedValueΦResultElementCalculation
    {
        IExpectedValueΦResultElement Calculate(
            IExpectedValueΦResultElementFactory expectedValueΦResultElementFactory,
            IlIndexElement lIndexElement,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            IL L,
            Ip p,
            Iμ μ);
    }
}