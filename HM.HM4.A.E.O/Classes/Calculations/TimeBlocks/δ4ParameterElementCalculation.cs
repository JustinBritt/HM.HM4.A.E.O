namespace HM.HM4.A.E.O.Classes.Calculations.TimeBlocks
{
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

            int γSum = 0;

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
                int δ4 = 1;

                do
                {
                    γSum = t.GetNthElementsAt(
                        dIndexElement.Value.Value.Value,
                        dIndexElement.Value.Value.Value + (δ4 - 1) * W.Value.Value.Value,
                        W.Value.Value.Value)
                        .Select(x => γ.GetElementAtAsint(
                            rIndexElement,
                            t.GetElementAt(x.Key)))
                        .Sum();

                    δ4 = δ4 + 1;
                } while (γSum < δ3Asint);

                if (γSum == δ3Asint)
                {
                    δ4ParameterElement = δ4ParameterElementFactory.Create(
                            sIndexElement,
                            rIndexElement,
                            dIndexElement,
                            tIndexElement,
                            δ4 - 1); // Subtract 1 to account for last iteration of the do-while loop
                }
            }

            return δ4ParameterElement;
        }
    }
}