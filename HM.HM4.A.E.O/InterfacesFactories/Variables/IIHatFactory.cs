namespace HM.HM4.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Variables;

    public interface IIHatFactory
    {
        IIHat Create(
            VariableCollection<ItIndexElement, IΛIndexElement> value);
    }
}