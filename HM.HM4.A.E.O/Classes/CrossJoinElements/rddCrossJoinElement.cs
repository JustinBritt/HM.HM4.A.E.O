namespace HM.HM4.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class rddCrossJoinElement : IrddCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rddCrossJoinElement(
            IrIndexElement rIndexElement,
            IdIndexElement d1IndexElement,
            IdIndexElement d2IndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.d1IndexElement = d1IndexElement;

            this.d2IndexElement = d2IndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public IdIndexElement d1IndexElement { get; }

        public IdIndexElement d2IndexElement { get; }
    }
}