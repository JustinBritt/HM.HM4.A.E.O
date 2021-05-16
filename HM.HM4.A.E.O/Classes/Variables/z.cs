namespace HM.HM4.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    internal sealed class z : Iz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public z(
            VariableCollection<IsIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonDayAssignments.Iz GetElementsAt(
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Ist st)
        {
            return zFactory.Create(
                st.Value
                .Select(
                    i => zResultElementFactory.Create(
                        i.sIndexElement,
                        i.tIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.tIndexElement)))
                .ToImmutableList());
        }
    }
}