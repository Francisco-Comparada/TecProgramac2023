using AgentSalaries.Administrative;

namespace AgentSalaries.Agent;

public class PatrolAgent : Agent
{
    private string specialty { get; set; }
    private string classification { get; set; }
    private string variableAmount { get; set; }

    public PatrolAgent(int registrationNumber, string name, string position, DateTime dateOfAdmission,
        BaseSalary baseSalary, string specialty, string classification, string variableAmount) : base(
        registrationNumber, name, position, dateOfAdmission, baseSalary)
    {
        this.specialty = specialty;
        this.classification = classification;
        this.variableAmount = variableAmount;
    }

    public override double CalculateSalary()
    {
        throw new NotImplementedException();
    }
}