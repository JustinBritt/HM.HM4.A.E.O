namespace HM.HM4.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class srCrossJoinElementFactory : IsrCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srCrossJoinElementFactory()
        {
        }

        public IsrCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement)
        {
            IsrCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new srCrossJoinElement(
                    sIndexElement,
                    rIndexElement);
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