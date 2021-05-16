namespace HM.HM4.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class Constraints2ConstraintElement : IConstraints2ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElement(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            Ix x,
            Iz z)
        {
            Expression LHS = Expression.Sum(
                r.Value
                .Select(
                   y => x.Value[sIndexElement, y, tIndexElement]));

            Expression RHS = z.Value[sIndexElement, tIndexElement];

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}