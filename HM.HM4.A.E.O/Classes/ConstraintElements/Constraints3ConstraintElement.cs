namespace HM.HM4.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class Constraints3ConstraintElement : IConstraints3ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Iγ γ,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                s.Value
                .Select(
                    y => x.Value[y, rIndexElement, tIndexElement]));

            int RHS = γ.GetElementAtAsint(
                rIndexElement,
                tIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}