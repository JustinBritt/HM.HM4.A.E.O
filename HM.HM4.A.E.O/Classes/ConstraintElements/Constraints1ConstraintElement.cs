namespace HM.HM4.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class Constraints1ConstraintElement : IConstraints1ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElement(
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            It t,
            IW W,
            Iβ β,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                t.GetNthElementsAt(
                    dIndexElement.Value.Value.Value,
                    t.GetT() - W.Value.Value.Value + dIndexElement.Value.Value.Value,
                    W.Value.Value.Value)
                .Select(
                y => x.Value[sIndexElement, rIndexElement, y]));

            int RHS = β.GetElementAtAsint(
                sIndexElement,
                rIndexElement,
                dIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}