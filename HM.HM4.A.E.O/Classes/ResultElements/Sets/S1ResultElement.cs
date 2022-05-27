namespace HM.HM4.A.E.O.Classes.ResultElements.Sets
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;

    internal sealed class S1ResultElement : IS1ResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1ResultElement(
            IrIndexElement rIndexElement)
        {
            this.rIndexElement = rIndexElement;
        }

        public IrIndexElement rIndexElement { get; }
    }
}