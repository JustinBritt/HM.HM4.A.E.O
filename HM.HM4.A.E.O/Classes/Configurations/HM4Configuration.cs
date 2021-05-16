namespace HM.HM4.A.E.O.Classes.Configurations
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using HM.HM4.A.E.O.Interfaces.Configurations;

    internal sealed class HM4Configuration : IHM4Configuration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4Configuration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}