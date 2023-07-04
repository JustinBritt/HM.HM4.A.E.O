namespace HM.HM4.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class OperatingRoomDayAssignedAvailabilitiesOuterVisitor<TKey, TValue> : IOperatingRoomDayAssignedAvailabilitiesOuterVisitor<TKey, TValue>
        where TKey : Location
        where TValue : RedBlackTree<FhirDateTime, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OperatingRoomDayAssignedAvailabilitiesOuterVisitor(
            IγParameterElementFactory γParameterElementFactory,
            Ir r,
            It t)
        {
            this.γParameterElementFactory = γParameterElementFactory;

            this.r = r;

            this.t = t;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>>();
        }

        private IγParameterElementFactory γParameterElementFactory { get; }

        private Ir r { get; }

        private It t { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            RedBlackTree<FhirDateTime, INullableValue<bool>> value = obj.Value;

            IOperatingRoomDayAssignedAvailabilitiesInnerVisitor<FhirDateTime, INullableValue<bool>> innerVisitor = new OperatingRoomDayAssignedAvailabilitiesInnerVisitor<FhirDateTime, INullableValue<bool>>(
                this.γParameterElementFactory,
                rIndexElement,
                this.t);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                rIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}