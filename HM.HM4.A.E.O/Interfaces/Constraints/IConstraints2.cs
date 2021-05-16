namespace HM.HM4.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints2
    {
        ImmutableList<IConstraints2ConstraintElement> Value { get; }
    }
}