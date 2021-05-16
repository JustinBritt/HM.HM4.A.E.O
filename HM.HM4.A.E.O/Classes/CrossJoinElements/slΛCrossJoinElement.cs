namespace HM.HM4.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class slΛCrossJoinElement : IslΛCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public slΛCrossJoinElement(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.lIndexElement = lIndexElement;

            this.ΛIndexElement = ΛIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IΛIndexElement ΛIndexElement { get; }
    }
}