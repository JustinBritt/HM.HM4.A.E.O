namespace HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments
{
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;

    public interface IzResultElementFactory
    {
        IzResultElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            bool value);
    }
}