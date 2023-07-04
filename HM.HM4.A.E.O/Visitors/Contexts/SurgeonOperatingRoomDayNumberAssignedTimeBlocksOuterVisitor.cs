namespace HM.HM4.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonOperatingRoomDayNumberAssignedTimeBlocksOuterVisitor<TKey, TValue> : ISurgeonOperatingRoomDayNumberAssignedTimeBlocksOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomDayNumberAssignedTimeBlocksOuterVisitor(
            IβParameterElementFactory βParameterElementFactory,
            HM.HM4.A.E.O.Interfaces.Indices.Id d,
            Ir r,
            Is s)
        {
            this.βParameterElementFactory = βParameterElementFactory;

            this.d = d;

            this.r = r;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>>();
        }

        private IβParameterElementFactory βParameterElementFactory { get; }

        private HM.HM4.A.E.O.Interfaces.Indices.Id d { get; }

        private Ir r { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>> value = obj.Value;

            ISurgeonOperatingRoomDayNumberAssignedTimeBlocksFirstInnerVisitor<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>> innerVisitor = new SurgeonOperatingRoomDayNumberAssignedTimeBlocksFirstInnerVisitor<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                this.βParameterElementFactory,
                sIndexElement,
                this.d,
                this.r);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}