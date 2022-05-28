namespace HM.HM4.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class rdCrossJoinElement : IrdCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rdCrossJoinElement(
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.dIndexElement = dIndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public IdIndexElement dIndexElement { get; }
    }
}