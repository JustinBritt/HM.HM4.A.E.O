namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.CrossJoinElements;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public IdtCrossJoinElementFactory CreatedtCrossJoinElementFactory()
        {
            IdtCrossJoinElementFactory factory = null;

            try
            {
                factory = new dtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrtCrossJoinElementFactory CreatertCrossJoinElementFactory()
        {
            IrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new rtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslCrossJoinElementFactory CreateslCrossJoinElementFactory()
        {
            IslCrossJoinElementFactory factory = null;

            try
            {
                factory = new slCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslΛCrossJoinElementFactory CreateslΛCrossJoinElementFactory()
        {
            IslΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new slΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory()
        {
            IsrCrossJoinElementFactory factory = null;

            try
            {
                factory = new srCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrdCrossJoinElementFactory CreatesrdCrossJoinElementFactory()
        {
            IsrdCrossJoinElementFactory factory = null;

            try
            {
                factory = new srdCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrdtCrossJoinElementFactory CreatesrdtCrossJoinElementFactory()
        {
            IsrdtCrossJoinElementFactory factory = null;

            try
            {
                factory = new srdtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrtCrossJoinElementFactory CreatesrtCrossJoinElementFactory()
        {
            IsrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new srtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IstCrossJoinElementFactory CreatestCrossJoinElementFactory()
        {
            IstCrossJoinElementFactory factory = null;

            try
            {
                factory = new stCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsΛCrossJoinElementFactory CreatesΛCrossJoinElementFactory()
        {
            IsΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new sΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ItΛCrossJoinElementFactory CreatetΛCrossJoinElementFactory()
        {
            ItΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new tΛCrossJoinElementFactory();
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