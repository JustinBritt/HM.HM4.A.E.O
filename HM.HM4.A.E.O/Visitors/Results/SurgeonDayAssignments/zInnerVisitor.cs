namespace HM.HM4.A.E.O.Visitors.Results.SurgeonDayAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.Comparers;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM4.A.E.O.InterfacesVisitors.Results.SurgeonDayAssignments;

    internal sealed class zInnerVisitor<TKey, TValue> : IzInnerVisitor<TKey, TValue>
        where TKey : ItIndexElement
        where TValue : IzResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public zInnerVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = new RedBlackTree<FhirDateTime, INullableValue<bool>>(
                FhirDateTimeComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, INullableValue<bool>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<bool>(
                    obj.Value.Value));
        }
    }
}