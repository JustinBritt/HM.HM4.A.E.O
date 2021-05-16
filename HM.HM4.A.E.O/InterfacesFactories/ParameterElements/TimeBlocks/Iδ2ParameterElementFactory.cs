namespace HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;

    public interface Iδ2ParameterElementFactory
    {
        Iδ2ParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            int value);
    }
}