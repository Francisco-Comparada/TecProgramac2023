using AgentSalaries.Administrative;

namespace AgentSalaries.Agent;
// clase agente de parulla que hereda de agente 
public class PatrolAgent : Agent
{
    private string specialty { get; set; }
    private string classification { get; set; }
    private string variableAmount { get; set; }

    public PatrolAgent(int registrationNumber, string name, string position, DateTime dateOfAdmission,
         string specialty, string classification, string variableAmount) : base(
        registrationNumber, name, position, dateOfAdmission)
    {
        this.specialty = specialty;
        this.classification = classification;
        this.variableAmount = variableAmount;
    }

    public override double CalculateSalary()
    {
        Console.WriteLine("patrol" + BaseSalary.baseSalaryPatrol);
        return 0;
    }
}