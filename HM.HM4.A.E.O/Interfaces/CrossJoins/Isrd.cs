namespace HM.HM4.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;

    public interface Isrd
    {
        ImmutableList<IsrdCrossJoinElement> Value { get; }
    }
}