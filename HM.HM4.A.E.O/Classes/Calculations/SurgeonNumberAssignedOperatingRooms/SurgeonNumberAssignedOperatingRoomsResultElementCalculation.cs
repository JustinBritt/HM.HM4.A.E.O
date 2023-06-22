namespace HM.HM4.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsResultElementCalculation : ISurgeonNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            IsIndexElement sIndexElement,
            Ix x)
        {
            return surgeonNumberAssignedOperatingRoomsResultElementFactory.Create(
                sIndexElement,
                x.GetElementsAsImmutableList().Where(i => i.sIndexElement == sIndexElement && i.Value).Select(i => i.rIndexElement).Distinct().Count());
        }
    }
}