namespace HM.HM4.A.E.O.Classes.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    internal sealed class Δ : IΔ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Δ(
            RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> redBlackTree,
            ImmutableList<IΔParameterElement> value)
        {
            this.RedBlackTree = redBlackTree;

            this.Value = value;
        }

        public RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> RedBlackTree { get; }

        public ImmutableList<IΔParameterElement> Value { get; }

        public IjIndexElement GetSurgicalSpecialtyOfSurgeon(
            IsIndexElement sIndexElement)
        {
            IjIndexElement value = null;

            foreach (IΔParameterElement ΔParameterElement in this.Value)
            {
                if (this.IsSurgeonMemberOfSurgicalSpecialty(
                    ΔParameterElement.jIndexElement,
                    sIndexElement))
                {
                    value = ΔParameterElement.jIndexElement;
                }
            }

            return value;
        }

        public bool IsSurgeonMemberOfSurgicalSpecialty(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault()
                .Contains(sIndexElement);
        }
    }
}