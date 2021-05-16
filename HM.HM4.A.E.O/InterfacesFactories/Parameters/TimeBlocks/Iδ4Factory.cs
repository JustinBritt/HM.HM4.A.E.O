namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;

    public interface Iδ4Factory
    {
        Iδ4 Create(
            ImmutableList<Iδ4ParameterElement> value);
    }
}