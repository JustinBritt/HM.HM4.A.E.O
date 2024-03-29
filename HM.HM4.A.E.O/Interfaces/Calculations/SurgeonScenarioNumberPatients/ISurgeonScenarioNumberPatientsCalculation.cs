﻿namespace HM.HM4.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients
{
    using HM.HM4.A.E.O.Interfaces.CrossJoins;
    using HM.HM4.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM4.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using HM.HM4.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsCalculation
    {
        ISurgeonScenarioNumberPatients Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            ISurgeonScenarioNumberPatientsFactory surgeonScenarioNumberPatientsFactory,
            ISurgeonScenarioNumberPatientsResultElementCalculation surgeonScenarioNumberPatientsResultElementCalculation,
            Irt rt,
            IsΛ sΛ,
            In n,
            Ix x);
    }
}