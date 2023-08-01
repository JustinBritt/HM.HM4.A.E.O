namespace HM.HM4.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IConstraints5ConstraintElementFactory
    {
        IConstraints5ConstraintElement Create(
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            It t,
            IW W,
            Iδ1 δ1,
            Iδ2 δ2,
            Iδ4 δ4,
            Ix x);
    }
}