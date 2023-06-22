namespace HM.HM4.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM4.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> redBlackTree,
            ImmutableList<IxResultElement> value)
        {
            this.RedBlackTree = redBlackTree;

            this.Value = value;
        }

        private RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> RedBlackTree { get; }

        public ImmutableList<IxResultElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.rIndexElement == rIndexElement && x.tIndexElement == tIndexElement)
                .Select(x => x.Value ? 1 : 0)
                .SingleOrDefault();
        }
        
        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IxOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> xOuterVisitor = new HM.HM4.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments.xOuterVisitor<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>>(
                nullableValueFactory,
                new HM.HM4.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new HM.HM4.A.E.O.Classes.Comparers.LocationComparer(),
                new HM.HM4.A.E.O.Classes.Comparers.OrganizationComparer());

            this.RedBlackTree.AcceptVisitor(
                xOuterVisitor);

            return xOuterVisitor.RedBlackTree;
        }
    }
}