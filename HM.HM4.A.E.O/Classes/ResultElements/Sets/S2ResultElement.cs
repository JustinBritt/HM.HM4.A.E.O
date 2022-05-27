namespace HM.HM4.A.E.O.Classes.ResultElements.Sets
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;

    internal sealed class S2ResultElement : IS2ResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2ResultElement(
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