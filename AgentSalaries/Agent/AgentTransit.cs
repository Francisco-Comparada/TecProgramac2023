using AgentSalaries.Administrative;

namespace AgentSalaries.Agent;

public class AgentTransit : Agent
{
    public List<TrafficFines> finesIssued { get; set; }

    public AgentTransit(int registrationNumber, string name, string position, DateTime dateOfAdmission,
        BaseSalary baseSalary, List<TrafficFines> finesIssued) : base(registrationNumber,
        name, position, dateOfAdmission, baseSalary)
    {
        this.finesIssued = finesIssued;
    }

    public override double CalculateSalary()
    {
        throw new NotImplementedException();
    }
}