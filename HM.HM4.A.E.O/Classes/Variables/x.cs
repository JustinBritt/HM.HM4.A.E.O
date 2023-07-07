namespace HM.HM4.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, rIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Ir r,
            Is s,
            It t)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> outerRedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>> firstInnerRedBlackTree = new RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>();

                foreach (IrIndexElement rIndexElement in r.Value.Values)
                {
                    RedBlackTree<ItIndexElement, IxResultElement> secondInnerRedBlackTree = new RedBlackTree<ItIndexElement, IxResultElement>();

                    foreach (ItIndexElement tIndexElement in t.Value.Values)
                    {
                        secondInnerRedBlackTree.Add(
                            tIndexElement,
                            xResultElementFactory.Create(
                                sIndexElement,
                                rIndexElement,
                                tIndexElement,
                                this.GetElementAt(
                                    sIndexElement,
                                    rIndexElement,
                                    tIndexElement)));
                    }

                    firstInnerRedBlackTree.Add(
                        rIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    firstInnerRedBlackTree);
            }

            return xFactory.Create(
                outerRedBlackTree);
        }
    }
}