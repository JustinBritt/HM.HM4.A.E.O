namespace HM.HM4.A.E.O.Factories.Solutions
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Solutions;
    using HM.HM4.A.E.O.Interfaces.Solutions;
    using HM.HM4.A.E.O.InterfacesFactories.Solutions;

    internal sealed class HM4SolutionFactory : IHM4SolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4SolutionFactory()
        {
        }

        public IHM4Solution Create()
        {
            IHM4Solution solution = null;

            try
            {
                solution = new HM4Solution();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}