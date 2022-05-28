namespace HM.HM4.A.E.O.InterfacesFactories.Results.Sets
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;
   
    public interface IS2Factory
    {
        IS2 Create(
            ImmutableList<IS2ResultElement> value);
    }
}