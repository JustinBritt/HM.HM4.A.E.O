namespace HM.HM4.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class srtCrossJoinElementFactory : IsrtCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srtCrossJoinElementFactory()
        {
        }

        public IsrtCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            IsrtCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new srtCrossJoinElement(
                    sIndexElement,
                    rIndexElement,
                    tIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}