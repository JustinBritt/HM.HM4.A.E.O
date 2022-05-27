namespace HM.HM4.A.E.O.Factories.ResultElements.Sets
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets;

    internal sealed class S1ResultElementFactory : IS1ResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1ResultElementFactory()
        {
        }

        public IS1ResultElement Create(
            IrIndexElement rIndexElement)
        {
            IS1ResultElement resultElement = null;

            try
            {
                resultElement = new S1ResultElement(
                    rIndexElement);
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