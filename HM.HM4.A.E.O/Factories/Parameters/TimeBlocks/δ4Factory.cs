namespace HM.HM4.A.E.O.Factories.Parameters.TimeBlocks
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    internal sealed class δ4Factory : Iδ4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4Factory()
        {
        }

        public Iδ4 Create(
            ImmutableList<Iδ4ParameterElement> value)
        {
            Iδ4 parameter = null;

            try
            {
                parameter = new δ4(
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