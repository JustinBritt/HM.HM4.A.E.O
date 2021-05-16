namespace HM.HM4.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;

    public interface IsΛ
    {
        ImmutableList<IsΛCrossJoinElement> Value { get; }
    }
}