namespace HM.HM4.A.E.O.Classes.ConstraintElements
{
    using System;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class Constraints6ConstraintElement : IConstraints6ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElement(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IΦHat ΦVHat,
            IIHat IHat,
            Iz z)
        {
            Expression LHS = IHat.Value[tIndexElement, ΛIndexElement];

            Expression RHS = Expression.Sum(
                st.Value
                .Select(
                   y =>
                   (double)ΦVHat.GetElementAtAsdecimal(
                       y.sIndexElement,
                       l.GetElementAt(
                           tIndexElement.Key
                           - 
                           y.tIndexElement.Key
                           + 
                           (int)Math.Floor(
                               (decimal)(y.tIndexElement.Key)
                               /
                               (tIndexElement.Key + 1))
                           *
                           t.GetT()),
                       ΛIndexElement)
                   *
                   z.Value[y.sIndexElement, y.tIndexElement]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}