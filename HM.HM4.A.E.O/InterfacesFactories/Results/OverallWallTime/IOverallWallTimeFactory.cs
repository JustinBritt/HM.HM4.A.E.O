﻿namespace HM.HM4.A.E.O.InterfacesFactories.Results.OverallWallTime
{
    using System;

    using HM.HM4.A.E.O.Interfaces.Results.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}