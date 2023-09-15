namespace HM.HM4.A.E.O.Classes.Results.SurgeonNumberAssignedWeekdays
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonNumberAssignedWeekdays : ISurgeonNumberAssignedWeekdays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedWeekdays(
            ImmutableList<ISurgeonNumberAssignedWeekdaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonNumberAssignedWeekdaysResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new(
                new HM.HM4.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgeonNumberAssignedWeekdaysResultElement surgeonNumberAssignedWeekdaysResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgeonNumberAssignedWeekdaysResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgeonNumberAssignedWeekdaysResultElement.Value));
            }

            return redBlackTree;
        }
    }
}