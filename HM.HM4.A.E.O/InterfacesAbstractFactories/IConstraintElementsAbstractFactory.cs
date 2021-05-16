namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.ConstraintElements;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory();

        IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory();

        IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory();

        IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory();

        IConstraints5LConstraintElementFactory CreateConstraints5LConstraintElementFactory();

        IConstraints5UConstraintElementFactory CreateConstraints5UConstraintElementFactory();

        IConstraints6ConstraintElementFactory CreateConstraints6ConstraintElementFactory();
    }
}