﻿namespace HM.HM4.A.E.O.InterfacesAbstractFactories
{
    using HM.HM4.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IHM4ModelFactory CreateHM4ModelFactory();
    }
}