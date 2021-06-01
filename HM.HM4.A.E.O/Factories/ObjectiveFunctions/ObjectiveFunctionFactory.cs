namespace HM.HM4.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ObjectiveFunctions;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM4.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM4.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunctionFactory : IObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionFactory()
        {
        }

        public IObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            It t,
            IΛ Λ,
            IΡ Ρ,
            IIHat IHat)
        {
            IObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction(
                    objectiveFactory,
                    t,
                    Λ,
                    Ρ,
                    IHat);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}