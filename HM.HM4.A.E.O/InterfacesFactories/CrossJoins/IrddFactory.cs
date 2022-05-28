﻿namespace HM.HM4.A.E.O.InterfacesFactories.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM4.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM4.A.E.O.Interfaces.CrossJoins;

    public interface IrddFactory
    {
        Irdd Create(
            ImmutableList<IrddCrossJoinElement> value);
    }
}