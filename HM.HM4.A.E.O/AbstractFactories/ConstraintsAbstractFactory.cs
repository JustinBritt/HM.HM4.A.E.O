namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.Constraints;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.Constraints;

    internal sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConstraintsAbstractFactory()
        {
        }

        public IConstraints1Factory CreateConstraints1Factory()
        {
            IConstraints1Factory factory = null;

            try
            {
                factory = new Constraints1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints2Factory CreateConstraints2Factory()
        {
            IConstraints2Factory factory = null;

            try
            {
                factory = new Constraints2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints3Factory CreateConstraints3Factory()
        {
            IConstraints3Factory factory = null;

            try
            {
                factory = new Constraints3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints4Factory CreateConstraints4Factory()
        {
            IConstraints4Factory factory = null;

            try
            {
                factory = new Constraints4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5LFactory CreateConstraints5LFactory()
        {
            IConstraints5LFactory factory = null;

            try
            {
                factory = new Constraints5LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints5UFactory CreateConstraints5UFactory()
        {
            IConstraints5UFactory factory = null;

            try
            {
                factory = new Constraints5UFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraints6Factory CreateConstraints6Factory()
        {
            IConstraints6Factory factory = null;

            try
            {
                factory = new Constraints6Factory();
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