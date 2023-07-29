namespace HM.HM4.A.E.O.Classes.Calculations.TimeBlocks
{
    using System.Collections.Generic;
    using System.Linq;

    using log4net;

    using HM.HM4.A.E.O.Interfaces.Calculations.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.IndexElements;
    using HM.HM4.A.E.O.Interfaces.Indices;
    using HM.HM4.A.E.O.Interfaces.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Interfaces.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Interfaces.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class δ4ParameterElementCalculation : Iδ4ParameterElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δ4ParameterElementCalculation()
        {
        }

        public Iδ4ParameterElement Calculate(
            Iδ4ParameterElementFactory δ4ParameterElementFactory,
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            It t,
            IW W,
            Iγ γ,
            Iδ3 δ3)
        {
            Iδ4ParameterElement δ4ParameterElement = null;

            int δ3Asint = δ3.GetElementAtAsint(
                sIndexElement,
                rIndexElement,
                dIndexElement);

            if (δ3Asint == 0)
            {
                δ4ParameterElement = δ4ParameterElementFactory.Create(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement,
                    tIndexElement,
                    1);
            }
            else
            {
                List<KeyValuePair<int, int>> sums = new List<KeyValuePair<int, int>>();

                for (int candidate = 1; candidate <= 8; candidate = candidate + 1)
                {
                    int γSum = t.GetNthElementsAt(
                        tIndexElement.Key,
                        tIndexElement.Key + (candidate - 1) * W.Value.Value.Value,
                        W.Value.Value.Value)
                        .Select(x => γ.GetElementAtAsint(
                            rIndexElement,
                            x))
                        .Sum();

                    sums.Add(
                        KeyValuePair.Create(
                            candidate, 
                            γSum));
                }

                δ4ParameterElement = δ4ParameterElementFactory.Create(
                    sIndexElement,
                    rIndexElement,
                    dIndexElement,
                    tIndexElement,
                    sums.Where(w => w.Value == δ3Asint).Select(w => w.Key).SingleOrDefault());
            }

            return δ4ParameterElement;
        }
    }
}