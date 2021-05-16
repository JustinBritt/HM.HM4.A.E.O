namespace HM.HM4.A.E.O.Interfaces.Results.NumberOfExploredNodes
{
    public interface INumberOfExploredNodes
    {
        long Value { get; }

        long GetValueForOutputContext();
    }
}