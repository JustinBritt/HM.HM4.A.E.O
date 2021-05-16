namespace HM.HM4.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class d : HM.HM4.A.E.O.Interfaces.Indices.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            ImmutableList<IdIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IdIndexElement> Value { get; }

        public IdIndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}