namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxResultElementFactory
    {
        IxResultElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            bool value);
    }
}