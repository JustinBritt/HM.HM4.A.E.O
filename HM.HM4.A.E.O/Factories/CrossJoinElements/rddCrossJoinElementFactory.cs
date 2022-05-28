namespace HM.HM4.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class rddCrossJoinElementFactory : IrddCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rddCrossJoinElementFactory()
        {
        }

        public IrddCrossJoinElement Create(
            IrIndexElement rIndexElement,
            IdIndexElement d1IndexElement,
            IdIndexElement d2IndexElement)
        {
            IrddCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new rddCrossJoinElement(
                    rIndexElement: rIndexElement,
                    d1IndexElement: d1IndexElement,
                    d2IndexElement: d2IndexElement);
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