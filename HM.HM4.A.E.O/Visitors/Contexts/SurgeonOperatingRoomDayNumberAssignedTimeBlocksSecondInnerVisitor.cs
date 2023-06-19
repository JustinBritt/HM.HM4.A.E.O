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

    internal sealed class SurgeonOperatingRoomDayNumberAssignedTimeBlocksSecondInnerVisitor<TKey, TValue> : ISurgeonOperatingRoomDayNumberAssignedTimeBlocksSecondInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomDayNumberAssignedTimeBlocksSecondInnerVisitor(
            IβParameterElementFactory βParameterElementFactory,
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            HM.HM4.A.E.O.Interfaces.Indices.Id d)
        {
            this.βParameterElementFactory = βParameterElementFactory;

            this.sIndexElement = sIndexElement;

            this.rIndexElement = rIndexElement;

            this.d = d;

            this.RedBlackTree = new RedBlackTree<IdIndexElement, IβParameterElement>();
        }

        private IβParameterElementFactory βParameterElementFactory { get; }

        private IsIndexElement sIndexElement { get; }

        private IrIndexElement rIndexElement { get; }

        private HM.HM4.A.E.O.Interfaces.Indices.Id d { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IdIndexElement, IβParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IdIndexElement dIndexElement = this.d.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                dIndexElement,
                this.βParameterElementFactory.Create(
                    this.sIndexElement,
                    this.rIndexElement,
                    dIndexElement,
                    obj.Value));
        }
    }
}