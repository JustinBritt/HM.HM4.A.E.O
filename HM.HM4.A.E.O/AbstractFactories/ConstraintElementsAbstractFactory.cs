namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.ConstraintElements;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class ConstraintElementsAbstractFactory : IConstraintElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintElementsAbstractFactory()
        {
        }

        public IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory()
        {
            IConstraints1ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints1ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory()
        {
            IConstraints2ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints2ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory()
        {
            IConstraints3ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints3ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory()
        {
            IConstraints4ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints4ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5LConstraintElementFactory CreateConstraints5LConstraintElementFactory()
        {
            IConstraints5LConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5LConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5UConstraintElementFactory CreateConstraints5UConstraintElementFactory()
        {
            IConstraints5UConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints5UConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints6ConstraintElementFactory CreateConstraints6ConstraintElementFactory()
        {
            IConstraints6ConstraintElementFactory factory = null;

            try
            {
                factory = new Constraints6ConstraintElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}