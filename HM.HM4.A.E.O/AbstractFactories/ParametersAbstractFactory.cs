namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM4.A.E.O.Factories.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.Factories.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.Factories.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Factories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.Factories.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.Factories.Parameters.TimeBlockLength;
    using HM.HM4.A.E.O.Factories.Parameters.TimeBlocks;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.OperatingRoomDayAssignedAvailabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;
    using HM.HM4.A.E.O.InterfacesFactories.Parameters.TimeBlocks;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IHFactory CreateHFactory()
        {
            IHFactory factory = null;

            try
            {
                factory = new HFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IhFactory CreatehFactory()
        {
            IhFactory factory = null;

            try
            {
                factory = new hFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ILFactory CreateLFactory()
        {
            ILFactory factory = null;

            try
            {
                factory = new LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public InFactory CreatenFactory()
        {
            InFactory factory = null;

            try
            {
                factory = new nFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IWFactory CreateWFactory()
        {
            IWFactory factory = null;

            try
            {
                factory = new WFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IyFactory CreateyFactory()
        {
            IyFactory factory = null;

            try
            {
                factory = new yFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IβFactory CreateβFactory()
        {
            IβFactory factory = null;

            try
            {
                factory = new βFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IγFactory CreateγFactory()
        {
            IγFactory factory = null;

            try
            {
                factory = new γFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΔFactory CreateΔFactory()
        {
            IΔFactory factory = null;

            try
            {
                factory = new ΔFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Iδ1Factory Createδ1Factory()
        {
            Iδ1Factory factory = null;

            try
            {
                factory = new δ1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Iδ2Factory Createδ2Factory()
        {
            Iδ2Factory factory = null;

            try
            {
                factory = new δ2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Iδ3Factory Createδ3Factory()
        {
            Iδ3Factory factory = null;

            try
            {
                factory = new δ3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public Iδ4Factory Createδ4Factory()
        {
            Iδ4Factory factory = null;

            try
            {
                factory = new δ4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΡFactory CreateΡFactory()
        {
            IΡFactory factory = null;

            try
            {
                factory = new ΡFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IσFactory CreateσFactory()
        {
            IσFactory factory = null;

            try
            {
                factory = new σFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΦHatFactory CreateΦHatFactory()
        {
            IΦHatFactory factory = null;

            try
            {
                factory = new ΦHatFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΩFactory CreateΩFactory()
        {
            IΩFactory factory = null;

            try
            {
                factory = new ΩFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}