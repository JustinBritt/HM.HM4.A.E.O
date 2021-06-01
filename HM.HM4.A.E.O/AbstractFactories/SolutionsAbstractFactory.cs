namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.Solutions;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.Solutions;

    internal sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolutionsAbstractFactory()
        {
        }

        public IHM4SolutionFactory CreateHM4SolutionFactory()
        {
            IHM4SolutionFactory factory = null;

            try
            {
                factory = new HM4SolutionFactory();
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