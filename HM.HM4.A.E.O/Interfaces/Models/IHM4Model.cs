namespace HM.HM4.A.E.O.Interfaces.Models
{
    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IHM4Model
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Id d { get; }

        Ij j { get; }

        Il l { get; }

        Ir r { get; }

        Is s { get; }

        It t { get; }

        IΛ Λ { get; }

        Irdd rdd { get; }

        Irt rt { get; }

        IslΛ slΛ { get; }

        Isrt srt { get; }

        Ist st { get; }

        IsΛ sΛ { get; }

        ItΛ tΛ { get; }

        IH H { get; }

        Ih h { get; }

        IL L { get; }

        In n { get; }

        Ip p { get; }

        IW W { get; }

        IΔ Δ { get; }

        Iμ μ { get; }

        IΡ Ρ { get; }

        Iσ σ { get; }

        IΩ Ω { get; }

        IIHat IHat { get; }

        Ix x { get; }
         
        Iz z { get; }
    }
}