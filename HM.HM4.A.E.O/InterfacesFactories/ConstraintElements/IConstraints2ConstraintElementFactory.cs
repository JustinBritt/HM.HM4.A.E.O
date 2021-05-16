namespace HM.HM4.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IConstraints2ConstraintElementFactory
    {
        IConstraints2ConstraintElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            Ix x,
            Iz z);
    }
}