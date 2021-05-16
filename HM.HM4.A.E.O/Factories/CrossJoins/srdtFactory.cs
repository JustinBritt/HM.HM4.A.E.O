﻿namespace HM.HM4.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class srdtFactory : IsrdtFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srdtFactory()
        {
        }

        public Isrdt Create(
            ImmutableList<IsrdtCrossJoinElement> value)
        {
            Isrdt crossJoin = null;

            try
            {
                crossJoin = new srdt(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoin;
        }
    }
}