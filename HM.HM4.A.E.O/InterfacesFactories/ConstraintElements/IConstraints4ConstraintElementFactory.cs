namespace HM.HM4.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IConstraints4ConstraintElementFactory
    {
        IConstraints4ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iy y,
            Ix x);
    }
}