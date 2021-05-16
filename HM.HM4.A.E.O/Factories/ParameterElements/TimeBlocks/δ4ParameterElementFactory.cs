namespace HM.HM4.A.E.O.Factories.ParameterElements.TimeBlocks
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class δ4ParameterElementFactory : Iδ4ParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4ParameterElementFactory()
        {
        }

        public Iδ4ParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement,
            ItIndexElement tIndexElement,
            int value)
        {
            Iδ4ParameterElement parameterElement = null;

            try
            {
                parameterElement = new δ4ParameterElement(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement,
                    tIndexElement,
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