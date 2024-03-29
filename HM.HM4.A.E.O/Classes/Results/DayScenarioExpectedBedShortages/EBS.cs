﻿namespace HM.HM4.A.E.O.Classes.Results.DayScenarioExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class EBS : IEBS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBS(
            ImmutableList<IEBSResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IEBSResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement)
        {
            return this.Value
                .Where(x => x.tIndexElement == tIndexElement && x.ΛIndexElement == ΛIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            It t,
            IΛ Λ)
        {
            RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> outerRedBlackTree = new(
                new HM.HM4.A.E.O.Classes.Comparers.FhirDateTimeComparer());

            foreach (ItIndexElement tIndexElement in t.Value.Values)
            {
                RedBlackTree<INullableValue<int>, INullableValue<decimal>> innerRedBlackTree = new(
                    new HM.HM4.A.E.O.Classes.Comparers.NullableValueintComparer());

                foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ΛIndexElement.Value,
                        nullableValueFactory.Create<decimal>(
                            this.GetElementAtAsdecimal(
                                tIndexElement,
                                ΛIndexElement)));
                }

                outerRedBlackTree.Add(
                    tIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}