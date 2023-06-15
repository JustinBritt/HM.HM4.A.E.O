namespace HM.HM4.A.E.O.Factories.Comparers
{
    using HM.HM4.A.E.O.Classes.Comparers;
    using HM.HM4.A.E.O.Interfaces.Comparers;
    using HM.HM4.A.E.O.InterfacesFactories.Comparers;

    internal sealed class NullableValueintComparerFactory : INullableValueintComparerFactory
    {
        public NullableValueintComparerFactory()
        {
        }

        public INullableValueintComparer Create()
        {
            INullableValueintComparer instance = null;

            try
            {
                instance = new NullableValueintComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}