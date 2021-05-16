namespace HM.HM4.A.E.O.Classes.Calculations.ScenarioNumberPatients
{
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementCalculation : IScenarioNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementCalculation()
        {
        }

        public IScenarioNumberPatientsResultElement Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IΛIndexElement ΛIndexElement,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients)
        {
            return scenarioNumberPatientsResultElementFactory.Create(
                ΛIndexElement,
                surgeonScenarioNumberPatients.Value
                .Where(w => w.ΛIndexElement == ΛIndexElement)
                .Select(w => w.Value)
                .Sum());
        }
    }
}