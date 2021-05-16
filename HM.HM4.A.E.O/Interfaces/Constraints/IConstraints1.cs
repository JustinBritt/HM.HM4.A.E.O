namespace HM.HM4.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints1
    {
        ImmutableList<IConstraints1ConstraintElement> Value { get; }
    }
}