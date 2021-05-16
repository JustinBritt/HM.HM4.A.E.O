namespace HM.HM4.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IConstraints3ConstraintElementFactory
    {
        IConstraints3ConstraintElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Iγ γ,
            Ix x);
    }
}