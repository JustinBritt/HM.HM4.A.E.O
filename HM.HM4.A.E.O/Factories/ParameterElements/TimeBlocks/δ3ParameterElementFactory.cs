namespace HM.HM4.A.E.O.Factories.ParameterElements.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class δ3ParameterElementFactory : Iδ3ParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ3ParameterElementFactory()
        {
        }

        public Iδ3ParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            int value)
        {
            Iδ3ParameterElement parameterElement = null;

            try
            {
                parameterElement = new δ3ParameterElement(
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