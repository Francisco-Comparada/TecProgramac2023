using AgentSalaries.Administrative;

namespace AgentSalaries.Agent;

// clase agente de transito que hereda de agente 
public class AgentTransit : Agent
{
    public List<TrafficFines> finesIssued { get; set; }

    public AgentTransit(int registrationNumber, string name, string position, DateTime dateOfAdmission,
        List<TrafficFines> finesIssued) : base(registrationNumber,
        name, position, dateOfAdmission)
    {
        this.finesIssued = finesIssued;
    }

    public override double CalculateSalary()
    {
        Console.WriteLine("transit");
        return 0;
    }
}