﻿namespace HM.HM4.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class slΛFactory : IslΛFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public slΛFactory()
        {
        }

        public IslΛ Create(
            ImmutableList<IslΛCrossJoinElement> value)
        {
            IslΛ crossJoin = null;

            try
            {
                crossJoin = new slΛ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}