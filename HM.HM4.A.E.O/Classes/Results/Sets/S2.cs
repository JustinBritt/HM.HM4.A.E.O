namespace HM.HM4.A.E.O.Classes.Results.Sets
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;

    internal sealed class S2 : IS2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2(
            ImmutableList<IS2ResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IS2ResultElement> Value { get; }

        public bool IsThereElementAt(
            IrIndexElement rIndexElement,
            IdIndexElement d1IndexElement,
            IdIndexElement d2IndexElement)
        {
            int count = this.Value
                .Where(x => x.rIndexElement == rIndexElement && x.d1IndexElement == d1IndexElement && x.d2IndexElement == d2IndexElement)
                .Distinct()
                .Count();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ImmutableList<Tuple<Location, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext()
        {
            return this.Value
                .Select(
                i => Tuple.Create(
                    i.rIndexElement.Value,
                    (INullableValue<int>)i.d1IndexElement.Value,
                    (INullableValue<int>)i.d2IndexElement.Value))
                .ToImmutableList();
        }
    }
}