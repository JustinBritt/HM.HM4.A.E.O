namespace HM.HM4.A.E.O.Classes.Calculations.Sets
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.Sets;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Results.Sets;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.Sets;
    using HM.HM4.A.E.O.InterfacesFactories.Results.Sets;

    internal sealed class S1Calculation : IS1Calculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S1Calculation()
        {
        }

        public IS1 Calculate(
            IS1ResultElementFactory S1ResultElementFactory,
            IS1Factory S1Factory,
            Ir r,
            IΔ Δ,
            Ix x)
        {
            return S1Factory.Create(
                r.Value
                .Select(
                    i => Tuple.Create(
                        i,
                        x.Value
                        .Where(j => j.rIndexElement == i.Value && j.Value)
                        .Select(j => j.sIndexElement)
                        .Select(j => Δ.GetSurgicalSpecialtyOfSurgeon(j).Value)
                        .Distinct()
                        .Count()))
                .Where(i => i.Item2 > 1)
                .Select(i => S1ResultElementFactory.Create(i.Item1.Value))
                .ToImmutableList());
        }
    }
}