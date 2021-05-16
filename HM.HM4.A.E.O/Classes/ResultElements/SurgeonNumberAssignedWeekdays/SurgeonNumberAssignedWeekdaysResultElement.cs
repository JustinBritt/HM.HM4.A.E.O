namespace HM.HM4.A.E.O.Classes.ResultElements.SurgeonNumberAssignedWeekdays
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;

    internal sealed class SurgeonNumberAssignedWeekdaysResultElement : ISurgeonNumberAssignedWeekdaysResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdaysResultElement(
            IsIndexElement sIndexElement,
            int value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public int Value { get; }
    }
}