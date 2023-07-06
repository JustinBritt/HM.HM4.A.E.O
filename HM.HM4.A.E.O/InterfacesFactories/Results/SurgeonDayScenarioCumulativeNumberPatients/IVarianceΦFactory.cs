﻿namespace HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IVarianceΦFactory
    {
        IVarianceΦ Create(
            ImmutableList<IVarianceΦResultElement> value,
            Il l,
            Is s,
            IΛ Λ);
    }
}