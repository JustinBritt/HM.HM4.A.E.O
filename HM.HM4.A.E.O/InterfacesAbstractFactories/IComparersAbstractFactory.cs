namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}