namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;

    public interface ISurgeonNumberAssignedOperatingRoomsResultElementFactory
    {
        ISurgeonNumberAssignedOperatingRoomsResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}