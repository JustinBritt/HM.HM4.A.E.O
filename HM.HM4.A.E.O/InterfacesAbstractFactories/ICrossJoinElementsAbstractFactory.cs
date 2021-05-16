namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements;

    public interface ICrossJoinElementsAbstractFactory
    {
        IdtCrossJoinElementFactory CreatedtCrossJoinElementFactory();

        IrtCrossJoinElementFactory CreatertCrossJoinElementFactory();

        IslCrossJoinElementFactory CreateslCrossJoinElementFactory();

        IslΛCrossJoinElementFactory CreateslΛCrossJoinElementFactory();

        IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory();

        IsrdCrossJoinElementFactory CreatesrdCrossJoinElementFactory();

        IsrdtCrossJoinElementFactory CreatesrdtCrossJoinElementFactory();

        IsrtCrossJoinElementFactory CreatesrtCrossJoinElementFactory();

        IstCrossJoinElementFactory CreatestCrossJoinElementFactory();

        IsΛCrossJoinElementFactory CreatesΛCrossJoinElementFactory();

        ItΛCrossJoinElementFactory CreatetΛCrossJoinElementFactory();
    }
}