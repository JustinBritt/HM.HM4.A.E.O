namespace HM.HM4.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM4.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IHat : IIHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHat(
            RedBlackTree<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>> Value { get; }

        public decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value[tIndexElement][ΛIndexElement].Value;
        }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IIHatOuterVisitor<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>> IHatOuterVisitor = new HM.HM4.A.E.O.Visitors.Results.DayScenarioRecoveryWardCensuses.IHatOuterVisitor<ItIndexElement, RedBlackTree<IΛIndexElement, IIHatResultElement>>(
                nullableValueFactory,
                new HM.HM4.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new HM.HM4.A.E.O.Classes.Comparers.NullableValueintComparer());

            this.Value.AcceptVisitor(
                IHatOuterVisitor);

            return IHatOuterVisitor.RedBlackTree;
        }
    }
}