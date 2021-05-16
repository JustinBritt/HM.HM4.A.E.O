namespace HM.HM4.A.E.O.Factories.Parameters.TimeBlocks
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    internal sealed class δ1Factory : Iδ1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ1Factory()
        {
        }

        public Iδ1 Create(
            ImmutableList<Iδ1ParameterElement> value)
        {
            Iδ1 parameter = null;

            try
            {
                parameter = new δ1(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}