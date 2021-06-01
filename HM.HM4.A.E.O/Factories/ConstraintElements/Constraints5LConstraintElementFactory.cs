﻿namespace HM.HM4.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints5LConstraintElementFactory : IConstraints5LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5LConstraintElementFactory()
        {
        }

        public IConstraints5LConstraintElement Create(
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            It t,
            IW W,
            Iδ1 δ1,
            Iδ4 δ4,
            Ix x)
        {
            IConstraints5LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5LConstraintElement(
                    dIndexElement,
                    rIndexElement,
                    sIndexElement,
                    tIndexElement,
                    t,
                    W,
                    δ1,
                    δ4,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}