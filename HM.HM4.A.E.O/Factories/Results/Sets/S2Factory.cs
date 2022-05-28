namespace HM.HM4.A.E.O.Factories.Results.Sets
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM4.A.E.O.Classes.Results.Sets;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.Results.Sets;

    internal sealed class S2Factory : IS2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S2Factory()
        {
        }

        public IS2 Create(
            ImmutableList<IS2ResultElement> value)
        {
            IS2 result = null;

            try
            {
                result = new S2(
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