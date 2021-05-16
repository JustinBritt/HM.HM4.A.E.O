namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;

    public interface Iδ1Factory
    {
        Iδ1 Create(
            ImmutableList<Iδ1ParameterElement> value);
    }
}