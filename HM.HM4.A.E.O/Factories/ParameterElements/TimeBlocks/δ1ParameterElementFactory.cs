namespace HM.HM4.A.E.O.Factories.ParameterElements.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class δ1ParameterElementFactory : Iδ1ParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ1ParameterElementFactory()
        {
        }

        public Iδ1ParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            int value)
        {
            Iδ1ParameterElement parameterElement = null;

            try
            {
                parameterElement = new δ1ParameterElement(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}