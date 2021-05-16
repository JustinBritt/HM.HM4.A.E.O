﻿namespace HM.HM4.A.E.O.Interfaces.Calculations.TotalExpectedBedShortage
{
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage;

    public interface ITEBSCalculation
    {
        Interfaces.Results.TotalExpectedBedShortage.ITEBS Calculate(
            ITEBSFactory TEBSFactory,
            IΛ Λ,
            IΡ Ρ,
            Interfaces.Results.ScenarioTotalExpectedBedShortages.ITEBS TEBS);
    }
}