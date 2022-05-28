namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoins;

    public interface ICrossJoinsAbstractFactory
    {
        IdtFactory CreatedtFactory();

        IrddFactory CreaterddFactory();

        IrdFactory CreaterdFactory();

        IrtFactory CreatertFactory();

        IslFactory CreateslFactory();

        IslΛFactory CreateslΛFactory();

        IsrFactory CreatesrFactory();

        IsrdFactory CreatesrdFactory();

        IsrdtFactory CreatesrdtFactory();

        IsrtFactory CreatesrtFactory();

        IstFactory CreatestFactory();

        IsΛFactory CreatesΛFactory();

        ItΛFactory CreatetΛFactory();
    }
}