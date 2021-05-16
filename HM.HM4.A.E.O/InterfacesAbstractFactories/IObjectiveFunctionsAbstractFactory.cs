namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.ObjectiveFunctions;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IObjectiveFunctionFactory CreateObjectiveFunctionFactory();
    }
}