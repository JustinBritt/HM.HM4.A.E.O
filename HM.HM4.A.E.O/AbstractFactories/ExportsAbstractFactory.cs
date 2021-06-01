namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.Exports;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.Exports;

    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExportsAbstractFactory()
        {
        }

        public IHM4ExportFactory CreateHM4ExportFactory()
        {
            IHM4ExportFactory factory = null;

            try
            {
                factory = new HM4ExportFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}