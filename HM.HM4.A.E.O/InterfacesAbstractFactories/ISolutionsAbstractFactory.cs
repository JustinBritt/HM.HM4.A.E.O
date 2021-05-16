namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Solutions;

    public interface ISolutionsAbstractFactory
    {
        IHM4SolutionFactory CreateHM4SolutionFactory();
    }
}