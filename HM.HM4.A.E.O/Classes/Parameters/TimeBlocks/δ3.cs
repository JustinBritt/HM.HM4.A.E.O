namespace HM.HM4.A.E.O.Classes.Parameters.TimeBlocks
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;

    internal sealed class δ3 : Iδ3
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ3(
            ImmutableList<Iδ3ParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Iδ3ParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.rIndexElement == rIndexElement && x.dIndexElement == dIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }
    }
}