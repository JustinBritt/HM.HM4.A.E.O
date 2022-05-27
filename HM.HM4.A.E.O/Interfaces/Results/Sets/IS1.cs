namespace HM.HM4.A.E.O.Interfaces.Results.Sets
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.ResultElements.Sets;
    
    public interface IS1
    {
        ImmutableList<IS1ResultElement> Value { get; }

        bool IsThereElementAt(
            IrIndexElement rIndexElement);
    }
}