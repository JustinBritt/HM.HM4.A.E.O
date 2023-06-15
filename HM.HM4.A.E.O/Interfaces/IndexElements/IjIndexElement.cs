namespace HM.HM4.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IjIndexElement : IComparable<IjIndexElement>
    {
        /// <summary>
        /// Gets the surgical specialty.
        /// </summary>
        Organization Value { get; }
    }
}