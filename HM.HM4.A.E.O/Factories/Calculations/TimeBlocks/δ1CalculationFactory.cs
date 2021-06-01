namespace HM.HM4.A.E.O.Factories.Calculations.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.TimeBlocks;

    internal sealed class δ1CalculationFactory : Iδ1CalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ1CalculationFactory()
        {
        }

        public Iδ1Calculation Create()
        {
            Iδ1Calculation calculation = null;

            try
            {
                calculation = new δ1Calculation();
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