﻿namespace HM.HM4.A.E.O.Factories.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Classes.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;

    internal sealed class σFactory : IσFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public σFactory()
        {
        }

        public Iσ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, IσParameterElement>> value)
        {
            Iσ parameter = null;

            try
            {
                parameter = new σ(
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