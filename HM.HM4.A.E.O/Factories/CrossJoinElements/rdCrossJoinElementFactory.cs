namespace HM.HM4.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class rdCrossJoinElementFactory : IrdCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rdCrossJoinElementFactory()
        {
        }

        public IrdCrossJoinElement Create(
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            IrdCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new rdCrossJoinElement(
                    rIndexElement,
                    dIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}