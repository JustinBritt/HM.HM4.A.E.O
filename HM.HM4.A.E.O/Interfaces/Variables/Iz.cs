namespace HM.HM4.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    public interface Iz
    {
        VariableCollection<IsIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);

        Interfaces.Results.SurgeonDayAssignments.Iz GetElementsAt(
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Ist st);
    }
}