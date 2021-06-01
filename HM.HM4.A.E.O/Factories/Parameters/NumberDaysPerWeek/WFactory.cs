namespace HM.HM4.A.E.O.Factories.Parameters.NumberDaysPerWeek
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Classes.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;

    internal sealed class WFactory : IWFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WFactory()
        {
        }

        public IW Create(
            PositiveInt value)
        {
            IW parameter = null;

            try
            {
                parameter = new W(
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