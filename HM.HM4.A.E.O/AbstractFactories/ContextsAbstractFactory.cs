namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.Contexts;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.Contexts;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IHM4InputContextFactory CreateHM4InputContextFactory()
        {
            IHM4InputContextFactory factory = null;

            try
            {
                factory = new HM4InputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IHM4OutputContextFactory CreateHM4OutputContextFactory()
        {
            IHM4OutputContextFactory factory = null;

            try
            {
                factory = new HM4OutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}