namespace HM.HM4.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM4.A.E.O.Factories.Results.BestBound;
    using HM.HM4.A.E.O.Factories.Results.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.Factories.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.Factories.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.Factories.Results.Gap;
    using HM.HM4.A.E.O.Factories.Results.NumberOfExploredNodes;
    using HM.HM4.A.E.O.Factories.Results.ObjectiveValue;
    using HM.HM4.A.E.O.Factories.Results.OverallWallTime;
    using HM.HM4.A.E.O.Factories.Results.ScenarioNumberPatients;
    using HM.HM4.A.E.O.Factories.Results.ScenarioTotalTimes;
    using HM.HM4.A.E.O.Factories.Results.ScenarioUnderutilizations;
    using HM.HM4.A.E.O.Factories.Results.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.Factories.Results.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.Factories.Results.SurgeonDayAssignments;
    using HM.HM4.A.E.O.Factories.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.Factories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.Factories.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.Factories.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Factories.Results.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.Factories.Results.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesAbstractFactories;
    using HM.HM4.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;
    using HM.HM4.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM4.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM4.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IEBSFactory CreateEBSFactory()
        {
            IEBSFactory factory = null;

            try
            {
                factory = new EBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueIFactory CreateExpectedValueIFactory()
        {
            IExpectedValueIFactory factory = null;

            try
            {
                factory = new ExpectedValueIFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueΦFactory CreateExpectedValueΦFactory()
        {
            IExpectedValueΦFactory factory = null;

            try
            {
                factory = new ExpectedValueΦFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIHatFactory CreateIHatFactory()
        {
            IIHatFactory factory = null;

            try
            {
                factory = new IHatFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsFactory CreateScenarioNumberPatientsFactory()
        {
            IScenarioNumberPatientsFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesFactory CreateScenarioTotalTimesFactory()
        {
            IScenarioTotalTimesFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsFactory CreateScenarioUnderutilizationsFactory()
        {
            IScenarioUnderutilizationsFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesFactory CreateScenarioUnutilizedTimesFactory()
        {
            IScenarioUnutilizedTimesFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesFactory CreateScenarioUtilizedTimesFactory()
        {
            IScenarioUtilizedTimesFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsFactory CreateSurgeonNumberAssignedOperatingRoomsFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedWeekdaysFactory CreateSurgeonNumberAssignedWeekdaysFactory()
        {
            ISurgeonNumberAssignedWeekdaysFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedWeekdaysFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsFactory CreateSurgeonScenarioNumberPatientsFactory()
        {
            ISurgeonScenarioNumberPatientsFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysFactory()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedWeekdaysFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM4.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage.ITEBSFactory CreateTEBSFactory()
        {
            HM.HM4.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage.ITEBSFactory factory = null;

            try
            {
                factory = new HM.HM4.A.E.O.Factories.Results.TotalExpectedBedShortage.TEBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages.ITEBSFactory CreateTEBSΛFactory()
        {
            HM.HM4.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages.ITEBSFactory factory = null;

            try
            {
                factory = new HM.HM4.A.E.O.Factories.Results.ScenarioTotalExpectedBedShortages.TEBSFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceIFactory CreateVarianceIFactory()
        {
            IVarianceIFactory factory = null;

            try
            {
                factory = new VarianceIFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceΦFactory CreateVarianceΦFactory()
        {
            IVarianceΦFactory factory = null;

            try
            {
                factory = new VarianceΦFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxFactory CreatexFactory()
        {
            IxFactory factory = null;

            try
            {
                factory = new xFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IzFactory CreatezFactory()
        {
            IzFactory factory = null;

            try
            {
                factory = new zFactory();
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