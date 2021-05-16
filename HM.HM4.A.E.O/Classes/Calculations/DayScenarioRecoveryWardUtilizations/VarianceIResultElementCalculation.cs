namespace HM.HM4.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;

    internal sealed class VarianceIResultElementCalculation : IVarianceIResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceIResultElementCalculation()
        {
        }

        public IVarianceIResultElement Calculate(
            IVarianceIResultElementFactory varianceIResultElementFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IVarianceΦ varianceΦ,
            Iz z)
        {
            return varianceIResultElementFactory.Create(
                tIndexElement,
                ΛIndexElement,
                st.Value
                .Select(w =>
                varianceΦ.GetElementAtAsdecimal(
                    w.sIndexElement,
                    l.GetElementAt(
                        tIndexElement.Key
                        -
                        w.tIndexElement.Key
                        +
                        (int)Math.Floor(
                            (decimal)w.tIndexElement.Key
                            /
                            (tIndexElement.Key + 1))
                        *
                        t.GetT()),
                    ΛIndexElement)
                *
                z.GetElementAtAsint(
                    w.sIndexElement,
                    w.tIndexElement))
                .Sum());
        }
    }
}