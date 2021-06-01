namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Factories.ParameterElements.ScenarioProbabilities;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Factories.ParameterElements.SurgicalSpecialties;
    using HM.HM4.A.E.O.Factories.ParameterElements.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM4.A.E.O.InterfacesFactories.ParameterElements.TimeBlocks;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IhParameterElementFactory CreatehParameterElementFactory()
        {
            IhParameterElementFactory factory = null;

            try
            {
                factory = new hParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILParameterElementFactory CreateLParameterElementFactory()
        {
            ILParameterElementFactory factory = null;

            try
            {
                factory = new LParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public InParameterElementFactory CreatenParameterElementFactory()
        {
            InParameterElementFactory factory = null;

            try
            {
                factory = new nParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IyParameterElementFactory CreateyParameterElementFactory()
        {
            IyParameterElementFactory factory = null;

            try
            {
                factory = new yParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IβParameterElementFactory CreateβParameterElementFactory()
        {
            IβParameterElementFactory factory = null;

            try
            {
                factory = new βParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IγParameterElementFactory CreateγParameterElementFactory()
        {
            IγParameterElementFactory factory = null;

            try
            {
                factory = new γParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΔParameterElementFactory CreateΔParameterElementFactory()
        {
            IΔParameterElementFactory factory = null;

            try
            {
                factory = new ΔParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iδ1ParameterElementFactory Createδ1ParameterElementFactory()
        {
            Iδ1ParameterElementFactory factory = null;

            try
            {
                factory = new δ1ParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iδ2ParameterElementFactory Createδ2ParameterElementFactory()
        {
            Iδ2ParameterElementFactory factory = null;

            try
            {
                factory = new δ2ParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iδ3ParameterElementFactory Createδ3ParameterElementFactory()
        {
            Iδ3ParameterElementFactory factory = null;

            try
            {
                factory = new δ3ParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iδ4ParameterElementFactory Createδ4ParameterElementFactory()
        {
            Iδ4ParameterElementFactory factory = null;

            try
            {
                factory = new δ4ParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμParameterElementFactory CreateμParameterElementFactory()
        {
            IμParameterElementFactory factory = null;

            try
            {
                factory = new μParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΡParameterElementFactory CreateΡParameterElementFactory()
        {
            IΡParameterElementFactory factory = null;

            try
            {
                factory = new ΡParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IσParameterElementFactory CreateσParameterElementFactory()
        {
            IσParameterElementFactory factory = null;

            try
            {
                factory = new σParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΦHatParameterElementFactory CreateΦHatParameterElementFactory()
        {
            IΦHatParameterElementFactory factory = null;

            try
            {
                factory = new ΦHatParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}