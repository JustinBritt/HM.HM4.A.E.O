namespace HM.HM4.A.E.O.Factories.Configurations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM4.A.E.O.Classes.Configurations;
    using HM.HM4.A.E.O.Interfaces.Configurations;
    using HM.HM4.A.E.O.InterfacesFactories.Configurations;

    internal sealed class HM4ConfigurationFactory : IHM4ConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4ConfigurationFactory()
        {
        }

        public IHM4Configuration Create(
            Configuration configuration)
        {
            IHM4Configuration HM4Configuration = null;

            try
            {
                HM4Configuration = new HM4Configuration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return HM4Configuration;
        }
    }
}