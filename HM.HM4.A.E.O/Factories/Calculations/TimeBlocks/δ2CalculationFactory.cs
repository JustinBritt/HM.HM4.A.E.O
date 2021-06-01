namespace HM.HM4.A.E.O.Factories.Calculations.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.TimeBlocks;

    internal sealed class δ2CalculationFactory : Iδ2CalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ2CalculationFactory()
        {
        }

        public Iδ2Calculation Create()
        {
            Iδ2Calculation calculation = null;

            try
            {
                calculation = new δ2Calculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}