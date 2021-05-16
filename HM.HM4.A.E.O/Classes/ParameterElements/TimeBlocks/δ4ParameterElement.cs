namespace HM.HM4.A.E.O.Classes.ParameterElements.TimeBlocks
{
    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;

    internal sealed class δ4ParameterElement : Iδ4ParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4ParameterElement(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement,
            int value)
        {
            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.dIndexElement = dIndexElement;

            this.tIndexElement = tIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public ItIndexElement tIndexElement { get; }

        public int Value { get; }
    }
}