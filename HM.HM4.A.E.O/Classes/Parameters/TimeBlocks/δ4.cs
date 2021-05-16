namespace HM.HM4.A.E.O.Classes.Parameters.TimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;

    internal sealed class δ4 : Iδ4
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4(
            ImmutableList<Iδ4ParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Iδ4ParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.rIndexElement == rIndexElement && x.dIndexElement == dIndexElement && x.tIndexElement == tIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }
    }
}