namespace HM.HM4.A.E.O.Factories.Calculations.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.TimeBlocks;

    internal sealed class δ3ParameterElementCalculationFactory : Iδ3ParameterElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ3ParameterElementCalculationFactory()
        {
        }

        public Iδ3ParameterElementCalculation Create()
        {
            Iδ3ParameterElementCalculation calculation = null;

            try
            {
                calculation = new δ3ParameterElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}