namespace HM.HM4.A.E.O.Classes.Parameters.SurgeonDayScenarioCumulativeNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHat : IΦHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHat(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IsIndexElement sIndexElement,
            IlIndexElement lIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>> firstInnerTree = this.Value[sIndexElement];

            RedBlackTree<IΛIndexElement, IΦHatParameterElement> secondInnerTree;

            bool result = firstInnerTree.TryGetValue(
                lIndexElement,
                out secondInnerTree);

            if (result)
            {
                return secondInnerTree[ΛIndexElement].Value.Value.Value;
            }
            else
            {
                return 0m;
            }
        }
    }
}