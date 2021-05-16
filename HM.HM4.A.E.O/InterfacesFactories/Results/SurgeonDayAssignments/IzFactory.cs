namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayAssignments;

    public interface IzFactory
    {
        Iz Create(
            ImmutableList<IzResultElement> value);
    }
}