namespace HM.HM4.A.E.O.Factories.Parameters.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Classes.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class ΦHatFactory : IΦHatFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦHatFactory()
        {
        }

        public IΦHat Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IΦHatParameterElement>>> value)
        {
            IΦHat parameter = null;

            try
            {
                parameter = new ΦHat(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}