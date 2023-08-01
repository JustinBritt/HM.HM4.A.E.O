namespace HM.HM4.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5ConstraintElement : IConstraints5ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5ConstraintElement(
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            It t,
            IW W,
            Iδ1 δ1,
            Iδ2 δ2,
            Iδ4 δ4,
            Ix x)
        {
            this.Value = new Constraint(
                expression: Expression.Sum(
                t.GetNthElementsAt(
                    tIndexElement.Key,
                    tIndexElement.Key
                    +
                    (δ4.GetElementAtAsint(
                        sIndexElement,
                        rIndexElement,
                        dIndexElement,
                        tIndexElement)
                    - 1)
                    *
                    W.Value.Value.Value,
                    W.Value.Value.Value)
                .Select(
                   y => x.Value[sIndexElement, rIndexElement, y])),
                lowerBound: δ1.GetElementAtAsint(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement),
                upperBound: δ2.GetElementAtAsint(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement));
        }

        public Constraint Value { get; }
    }
}