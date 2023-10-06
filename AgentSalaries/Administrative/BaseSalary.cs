namespace AgentSalaries.Administrative;

// en esta clase ponemos los salarios bases para cada tipo de agente, de esta forma si se 
// quiere cambiar alguna vez es mas sensillo de hacer, o si se quiere implementar un sistema 
// externo o BD
public abstract class BaseSalary
{
    public const double baseSalaryTransit = 250000;
    public const double baseSalaryPatrol = 380000;
}