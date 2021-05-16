namespace HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;

    public interface IyFactory
    {
        Iy Create(
            ImmutableList<IyParameterElement> value);
    }
}