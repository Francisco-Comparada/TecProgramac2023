using AgentSalaries.Administrative;

namespace AgentSalaries.Agent;

public abstract class Agent
{
    private int registrationNumber { get; set; }
    private string name { get; set; }
    private string position { get; set; }
    private DateTime dateOfAdmission { get; set; }
    private BaseSalary BaseSalary { get; set; }

    protected Agent(int registrationNumber, string name, string position, DateTime dateOfAdmission,
        BaseSalary baseSalary)
    {
        this.registrationNumber = registrationNumber;
        this.name = name;
        this.position = position;
        this.dateOfAdmission = dateOfAdmission;
        this.BaseSalary = baseSalary;
    }


    public abstract double CalculateSalary();
}