namespace HM.HM4.A.E.O.Classes.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class SurgicalSpecialtyNumberAssignedWeekdaysResultElement : ISurgicalSpecialtyNumberAssignedWeekdaysResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedWeekdaysResultElement(
            IjIndexElement jIndexElement,
            int value)
        {
            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IjIndexElement jIndexElement { get; }

        public int Value { get; }
    }
}