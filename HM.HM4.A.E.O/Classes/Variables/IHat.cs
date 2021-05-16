namespace HM.HM4.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IHat : IIHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IHat(
            VariableCollection<ItIndexElement, IΛIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<ItIndexElement, IΛIndexElement> Value { get; }

        public decimal GetElementAt(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return (decimal)this.Value[tIndexElement, ΛIndexElement].Value;
        }

        public Interfaces.Results.DayScenarioRecoveryWardCensuses.IIHat GetElementsAt(
            IIHatResultElementFactory IHatResultElementFactory,
            IIHatFactory IHatFactory,
            ItΛ tΛ)
        {
            return IHatFactory.Create(
                tΛ.Value
                .Select(
                    i => IHatResultElementFactory.Create(
                        i.tIndexElement,
                        i.ΛIndexElement,
                        this.GetElementAt(
                            i.tIndexElement,
                            i.ΛIndexElement)))
                .ToImmutableList());
        }
    }
}