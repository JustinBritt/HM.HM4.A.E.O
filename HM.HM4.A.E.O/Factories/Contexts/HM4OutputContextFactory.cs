namespace HM.HM4.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Classes.Contexts;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.Interfaces.Contexts;
    using HM.HM4.A.E.O.Interfaces.Models;
    using HM.HM4.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM4OutputContextFactory : IHM4OutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4OutputContextFactory()
        {
        }

        public IHM4OutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM4Model HM4Model,
            Solution solution)
        {
            IHM4OutputContext context = null;

            try
            {
                context = new HM4OutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    HM4Model,
                    solution);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return context;
        }
    }
}