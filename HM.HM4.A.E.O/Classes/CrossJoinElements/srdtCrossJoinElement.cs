namespace HM.HM4.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class srdtCrossJoinElement : IsrdtCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srdtCrossJoinElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.dIndexElement = dIndexElement;

            this.tIndexElement = tIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public ItIndexElement tIndexElement { get; }
    }
}