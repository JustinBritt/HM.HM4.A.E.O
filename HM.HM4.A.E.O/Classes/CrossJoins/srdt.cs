namespace HM.HM4.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;

    internal sealed class srdt : Isrdt
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srdt(
            ImmutableList<IsrdtCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsrdtCrossJoinElement> Value { get; }
    }
}