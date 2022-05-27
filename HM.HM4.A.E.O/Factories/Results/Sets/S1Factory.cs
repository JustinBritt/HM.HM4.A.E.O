namespace HM.HM4.A.E.O.Factories.Results.Sets
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Results.Sets;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.Results.Sets;

    internal sealed class S1Factory : IS1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1Factory()
        {
        }

        public IS1 Create(
            ImmutableList<IS1ResultElement> value)
        {
            IS1 result = null;

            try
            {
                result = new S1(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}