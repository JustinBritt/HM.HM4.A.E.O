namespace HM.HM4.A.E.O.Classes.Solutions
{
    using System.Linq;
    using System.Threading.Tasks;

    using log4net;

    using OPTANO.Modeling.Common;
    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Interfaces;

    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.Interfaces.Configurations;
    using HM.HM4.A.E.O.Interfaces.Contexts;
    using HM.HM4.A.E.O.Interfaces.Models;
    using HM.HM4.A.E.O.Interfaces.Solutions;
    using HM.HM4.A.E.O.Interfaces.SolverConfigurations;
    
    internal sealed class HM4Solution : IHM4Solution
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM4Solution()
        {
        }

        public Task<IHM4OutputContext> Solve(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM4Configuration HM4Configuration,
            IHM4InputContext HM4InputContext,
            ISolverConfiguration solverConfiguration)
        {
            IHM4OutputContext HM4OutputContext = null;

            return Task.Run(() => 
            {
                using (ModelScope modelScope = dependenciesAbstractFactory.CreateModelScopeFactory().Create(HM4Configuration.Value))
                {
                    IHM4Model model = modelsAbstractFactory.CreateHM4ModelFactory().Create(
                        calculationsAbstractFactory,
                        comparersAbstractFactory,
                        constraintElementsAbstractFactory,
                        constraintsAbstractFactory,
                        crossJoinElementsAbstractFactory,
                        crossJoinsAbstractFactory,
                        dependenciesAbstractFactory,
                        indexElementsAbstractFactory,
                        indicesAbstractFactory,
                        objectiveFunctionsAbstractFactory,
                        parameterElementsAbstractFactory,
                        parametersAbstractFactory,
                        variablesAbstractFactory,
                        HM4InputContext);

                    OPTANO.Modeling.Optimization.Solver.ModelStatus modelStatus = OPTANO.Modeling.Optimization.Solver.ModelStatus.Unknown;

                    using (ISolver solver = dependenciesAbstractFactory.CreateSolverFactory().Create(solverConfiguration))
                    {
                        Solution solution = solver?.Solve(model?.Model);

                        if (solution?.ModelStatus == OPTANO.Modeling.Optimization.Solver.ModelStatus.Feasible)
                        {
                            model.Model.VariableCollections.ForEach(vc => vc.SetVariableValues(solution.VariableValues));

                            HM4OutputContext = contextsAbstractFactory.CreateHM4OutputContextFactory().Create(
                                calculationsAbstractFactory,
                                dependenciesAbstractFactory,
                                resultElementsAbstractFactory,
                                resultsAbstractFactory,
                                model,
                                solution);
                        }
                        else
                        {
                            while (modelStatus != OPTANO.Modeling.Optimization.Solver.ModelStatus.Feasible)
                            {
                                ConflictingSet conflictingSet = solution.ConflictingSet;

                                model.Model.RemoveConstraints(
                                    conflictingSet.ConstraintsLB.Where(w => w.IsRangeConstraint() == true).Select(w => w.Name));

                                model.Model.RemoveConstraints(
                                    conflictingSet.ConstraintsUB.Where(w => w.IsRangeConstraint() == true).Select(w => w.Name));

                                solution = solver?.Solve(
                                    model?.Model);

                                modelStatus = (OPTANO.Modeling.Optimization.Solver.ModelStatus)(solution?.ModelStatus);
                            }

                            model.Model.VariableCollections.ForEach(vc => vc.SetVariableValues(solution.VariableValues));

                            HM4OutputContext = contextsAbstractFactory.CreateHM4OutputContextFactory().Create(
                                calculationsAbstractFactory,
                                dependenciesAbstractFactory,
                                resultElementsAbstractFactory,
                                resultsAbstractFactory,
                                model,
                                solution);
                        }
                    }
                }

                return HM4OutputContext;
            });
        }
    }
}