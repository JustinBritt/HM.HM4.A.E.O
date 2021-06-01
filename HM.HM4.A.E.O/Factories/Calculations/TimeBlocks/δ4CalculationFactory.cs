namespace HM.HM4.A.E.O.Factories.Calculations.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Calculations.TimeBlocks;

    internal sealed class δ4CalculationFactory : Iδ4CalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4CalculationFactory()
        {
        }

        public Iδ4Calculation Create()
        {
            Iδ4Calculation calculation = null;

            try
            {
                calculation = new δ4Calculation();
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