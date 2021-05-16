namespace HM.HM4.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints4ConstraintElementFactory : IConstraints4ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElementFactory()
        {
        }

        public IConstraints4ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iy y,
            Ix x)
        {
            IConstraints4ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints4ConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    tIndexElement,
                    y,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}