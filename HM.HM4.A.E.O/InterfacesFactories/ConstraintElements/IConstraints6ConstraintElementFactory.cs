namespace HM.HM4.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM4.A.E.O.Interfaces.ConstraintElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IConstraints6ConstraintElementFactory
    {
        IConstraints6ConstraintElement Create(
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IΦHat ΦVHat,
            IIHat IHat,
            Iz z);
    }
}