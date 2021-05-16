namespace HM.HM4.A.E.O.Factories.Calculations.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.TimeBlocks;

    internal sealed class δ4ParameterElementCalculationFactory : Iδ4ParameterElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4ParameterElementCalculationFactory()
        {
        }

        public Iδ4ParameterElementCalculation Create()
        {
            Iδ4ParameterElementCalculation calculation = null;

            try
            {
                calculation = new δ4ParameterElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}