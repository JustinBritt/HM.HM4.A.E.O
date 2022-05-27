namespace HM.HM4.A.E.O.Classes.Results.Sets
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;

    internal sealed class S1 : IS1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1(
            ImmutableList<IS1ResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IS1ResultElement> Value { get; }

        public bool IsThereElementAt(
            IrIndexElement rIndexElement)
        {
            int count = this.Value
                .Where(x => x.rIndexElement == rIndexElement)
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
    }
}