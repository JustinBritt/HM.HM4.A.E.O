namespace HM.HM4.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class Constraints4ConstraintElement : IConstraints4ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iy y,
            Ix x)
        {
            Expression LHS = x.Value[sIndexElement, rIndexElement, tIndexElement];

            int RHS = y.GetElementAtAsint(
                sIndexElement,
                rIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}