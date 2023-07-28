﻿namespace HM.HM4.A.E.O.Classes.Calculations.TimeBlocks
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class δ1ParameterElementCalculation : Iδ1ParameterElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ1ParameterElementCalculation()
        {
        }

        public Iδ1ParameterElement Calculate(
            Iδ1ParameterElementFactory δ1ParameterElementFactory,
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            It t,
            IW W,
            Iβ β,
            Iγ γ)
        {
            int value = 0;

            int γSum = t.GetNthElementsAt(
                dIndexElement.Value.Value.Value,
                t.GetT() - W.Value.Value.Value + dIndexElement.Value.Value.Value,
                W.Value.Value.Value)
                .Select(
                y => γ.GetElementAtAsint(
                    rIndexElement,
                    y))
                .Sum();

            decimal γSumAsdecimal = (decimal)γSum;

            int βAsint = β.GetElementAtAsint(
                sIndexElement,
                rIndexElement,
                dIndexElement);

            decimal βAsdecimal = (decimal)βAsint;

            if (βAsint > 0)
            {
                // Case (i)
                if ((γSum % βAsint) == 0)
                {
                    value = 1;
                }
                else if ((γSum % βAsint) > 0)
                {
                    // Case (ii)
                    if (βAsdecimal < (γSumAsdecimal / 2m))
                    {
                        value = 0;
                    }
                    // Case (iii)
                    else if ((βAsdecimal > (γSumAsdecimal / 2m)) && (βAsint < γSum))
                    {
                        value =
                            (int)Math.Floor(
                                (γSumAsdecimal / (γSumAsdecimal - βAsdecimal)))
                            -
                            1;
                    }
                }
            }
            
            return δ1ParameterElementFactory.Create(
                sIndexElement,
                rIndexElement,
                dIndexElement,
                value);
        }
    }
}