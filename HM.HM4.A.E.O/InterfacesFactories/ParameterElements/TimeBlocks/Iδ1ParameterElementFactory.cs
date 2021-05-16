namespace HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;

    public interface Iδ1ParameterElementFactory
    {
        Iδ1ParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            int value);
    }
}