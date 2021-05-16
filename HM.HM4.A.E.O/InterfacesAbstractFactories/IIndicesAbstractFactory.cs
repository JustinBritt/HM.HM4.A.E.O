namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Indices;

    public interface IIndicesAbstractFactory
    {
        IdFactory CreatedFactory();

        IjFactory CreatejFactory();

        IlFactory CreatelFactory();

        IrFactory CreaterFactory();

        IsFactory CreatesFactory();

        ItFactory CreatetFactory();

        IΛFactory CreateΛFactory();
    }
}