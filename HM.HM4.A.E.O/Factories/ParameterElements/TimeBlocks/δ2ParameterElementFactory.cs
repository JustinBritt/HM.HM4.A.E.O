namespace HM.HM4.A.E.O.Factories.ParameterElements.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class δ2ParameterElementFactory : Iδ2ParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ2ParameterElementFactory()
        {
        }

        public Iδ2ParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            int value)
        {
            Iδ2ParameterElement parameterElement = null;

            try
            {
                parameterElement = new δ2ParameterElement(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}