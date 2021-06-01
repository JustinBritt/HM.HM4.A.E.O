namespace HM.HM4.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints1ConstraintElementFactory : IConstraints1ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElementFactory()
        {
        }

        public IConstraints1ConstraintElement Create(
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            It t,
            IW W,
            Iβ β,
            Ix x)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    dIndexElement,
                    rIndexElement,
                    sIndexElement,
                    t,
                    W,
                    β,
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