namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Variables;

    public interface IVariablesAbstractFactory
    {
        IIHatFactory CreateIHatFactory();

        IxFactory CreatexFactory();

        IzFactory CreatezFactory();
    }
}