namespace HM.HM4.A.E.O.InterfacesFactories.Results.Sets
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;

    public interface IS1Factory
    {
        IS1 Create(
            ImmutableList<IS1ResultElement> value);
    }
}