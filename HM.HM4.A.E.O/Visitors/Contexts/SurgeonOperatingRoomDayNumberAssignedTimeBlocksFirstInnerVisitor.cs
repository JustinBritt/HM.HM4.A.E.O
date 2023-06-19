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

    internal sealed class SurgeonOperatingRoomDayNumberAssignedTimeBlocksFirstInnerVisitor<TKey, TValue> : ISurgeonOperatingRoomDayNumberAssignedTimeBlocksFirstInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<int>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomDayNumberAssignedTimeBlocksFirstInnerVisitor(
            IβParameterElementFactory βParameterElementFactory,
            IsIndexElement sIndexElement,
            HM.HM4.A.E.O.Interfaces.Indices.Id d,
            Ir r)
        {
            this.βParameterElementFactory = βParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.d = d;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>>();
        }

        private IβParameterElementFactory βParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private HM.HM4.A.E.O.Interfaces.Indices.Id d { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<int>> value = obj.Value;

            var innerVisitor = new SurgeonOperatingRoomDayNumberAssignedTimeBlocksSecondInnerVisitor<INullableValue<int>, INullableValue<int>>(
                this.βParameterElementFactory,
                this.sIndexElement,
                rIndexElement,
                this.d);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}