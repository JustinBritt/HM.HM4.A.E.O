namespace HM.HM4.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class OperatingRoomDayAssignedAvailabilitiesInnerVisitor<TKey, TValue> : IOperatingRoomDayAssignedAvailabilitiesInnerVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OperatingRoomDayAssignedAvailabilitiesInnerVisitor(
            IγParameterElementFactory γParameterElementFactory,
            IrIndexElement rIndexElement,
            It t)
        {
            this.γParameterElementFactory = γParameterElementFactory;

            this.rIndexElement = rIndexElement;

            this.t = t;

            this.RedBlackTree = new RedBlackTree<ItIndexElement, IγParameterElement>();
        }

        private IγParameterElementFactory γParameterElementFactory { get; }

        private IrIndexElement rIndexElement { get; }

        private It t { get; }

        public bool HasCompleted => false;

        public RedBlackTree<ItIndexElement, IγParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            ItIndexElement tIndexElement = this.t.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                tIndexElement,
                this.γParameterElementFactory.Create(
                    this.rIndexElement,
                    tIndexElement,
                    obj.Value));
        }
    }
}