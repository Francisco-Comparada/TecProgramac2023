namespace AgentSalaries.Agent;

// clase que representa las multas
public class TrafficFines
{
    public double fineAmount { get; set; }
    public string infractionType { get; set; }
    public AgentTransit agent { get; set; }

    public TrafficFines(double fineAmount, string infractionType, AgentTransit agent)
    {
        this.fineAmount = fineAmount;
        this.infractionType = infractionType;
        this.agent = agent;
    }
}