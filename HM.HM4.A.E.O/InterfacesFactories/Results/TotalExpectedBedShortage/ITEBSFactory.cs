namespace HM.HM4.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage
{
    using HM.HM4.A.E.O.Interfaces.Results.TotalExpectedBedShortage;

    public interface ITEBSFactory
    {
        ITEBS Create(
            decimal value);
    }
}