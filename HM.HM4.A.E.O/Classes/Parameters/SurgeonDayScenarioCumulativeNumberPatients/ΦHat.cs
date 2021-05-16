namespace HM.HM4.A.E.O.Classes.Parameters.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHat : IΦHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHat(
            ImmutableList<IΦHatParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΦHatParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            decimal value = this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.lIndexElement == lIndexElement && x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();

            return value;
        }
    }
}