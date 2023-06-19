namespace HM.HM4.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Classes.Indices;
    using HM.HM4.A.E.O.Interfaces.Comparers;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.InterfacesFactories.Indices;

    internal sealed class dFactory : IdFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dFactory()
        {
        }

        public HM.HM4.A.E.O.Interfaces.Indices.Id Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IdIndexElement> value)
        {
            HM.HM4.A.E.O.Interfaces.Indices.Id index = null;

            try
            {
                index = new d(
                    this.CreateRedBlackTree(
                        nullableValueintComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<INullableValue<int>, IdIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IdIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IdIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IdIndexElement>(
                nullableValueintComparer);

            foreach (IdIndexElement dIndexElement in value)
            {
                redBlackTree.Add(
                    dIndexElement.Value,
                    dIndexElement);
            }

            return redBlackTree;
        }
    }
}