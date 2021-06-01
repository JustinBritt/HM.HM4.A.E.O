namespace HM.HM4.A.E.O.Factories.Exports
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Exports;
    using HM.HM4.A.E.O.Interfaces.Exports;
    using HM.HM4.A.E.O.InterfacesFactories.Exports;

    internal sealed class HM4ExportFactory : IHM4ExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4ExportFactory()
        {
        }

        public IHM4Export Create()
        {
            IHM4Export export = null;

            try
            {
                export = new HM4Export();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}