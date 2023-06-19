namespace HM.HM4.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;

    internal sealed class d : HM.HM4.A.E.O.Interfaces.Indices.Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            RedBlackTree<INullableValue<int>, IdIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IdIndexElement> Value { get; }

        public IdIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}