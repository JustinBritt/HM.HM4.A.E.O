﻿namespace HM.HM4.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM4.A.E.O.Classes.IndexElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class dIndexElementFactory : IdIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dIndexElementFactory()
        {
        }

        public IdIndexElement Create(
            INullableValue<int> value)
        {
            IdIndexElement indexElement = null;

            try
            {
                indexElement = new dIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}