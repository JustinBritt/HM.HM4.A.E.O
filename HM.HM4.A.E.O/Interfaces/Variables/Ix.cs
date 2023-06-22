namespace HM.HM4.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    public interface Ix
    {
        VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Isrt srt);
    }
}