namespace HM.HM4.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
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
            IRedBlackTreeFactory redBlackTreeFactory,
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Is s,
            It t)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<ItIndexElement, IzResultElement> innerRedBlackTree = redBlackTreeFactory.Create<ItIndexElement, IzResultElement>();

                foreach (ItIndexElement tIndexElement in t.Value.Values)
                {
                    innerRedBlackTree.Add(
                        tIndexElement,
                        zResultElementFactory.Create(
                            sIndexElement,
                            tIndexElement,
                            this.GetElementAt(
                                sIndexElement,
                                tIndexElement)));
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    innerRedBlackTree);
            }

            return zFactory.Create(
                outerRedBlackTree);
        }
    }
}