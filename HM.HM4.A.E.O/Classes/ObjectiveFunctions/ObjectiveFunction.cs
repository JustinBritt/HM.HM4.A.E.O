namespace HM.HM4.A.E.O.Classes.ObjectiveFunctions
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM4.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ObjectiveFunction : IObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            It t,
            IΛ Λ,
            IΡ Ρ,
            IIHat IHat)
        {
            Expression expression = Expression.Sum(
                Λ.Value.Values
                .Select(
                    x => (double)Ρ.GetElementAtAsdecimal(
                        x)
                    *
                    Expression.Maximum(
                        t.Value
                        .Select(y => (Expression)IHat.Value[y, x]))));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}