namespace HM.HM4.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM4.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IObjectiveFunctionFactory
    {
        IObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            It t,
            IΛ Λ,
            IΡ Ρ,
            IIHat IHat);
    }
}