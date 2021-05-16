namespace HM.HM4.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class sΛCrossJoinElement : IsΛCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sΛCrossJoinElement(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.ΛIndexElement = ΛIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }
    }
}