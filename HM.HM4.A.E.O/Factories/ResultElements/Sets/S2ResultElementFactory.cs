namespace HM.HM4.A.E.O.Factories.ResultElements.Sets
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets;

    internal sealed class S2ResultElementFactory : IS2ResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2ResultElementFactory()
        {
        }

        public IS2ResultElement Create(
            IrIndexElement rIndexElement,
            IdIndexElement d1IndexElement,
            IdIndexElement d2IndexElement)
        {
            IS2ResultElement resultElement = null;

            try
            {
                resultElement = new S2ResultElement(
                    rIndexElement: rIndexElement,
                    d1IndexElement: d1IndexElement,
                    d2IndexElement: d2IndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}