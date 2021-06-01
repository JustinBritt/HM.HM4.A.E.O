namespace HM.HM4.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Classes.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Variables;
    using HM.HM4.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints2ConstraintElementFactory : IConstraints2ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElementFactory()
        {
        }

        public IConstraints2ConstraintElement Create(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            Ix x,
            Iz z)
        {
            IConstraints2ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints2ConstraintElement(
                    sIndexElement,
                    tIndexElement,
                    r,
                    x,
                    z);
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