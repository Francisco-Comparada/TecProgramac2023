namespace AgentSalaries.Agents
{
    // clase que representa las multas
    public class TrafficTicket
    {
        // Atributos
        private double amount;
        private string infractionType;
        private TrafficAgent agent;

        // Constructor
        public TrafficTicket(double amount, string infractionType, TrafficAgent agent)
        {
            this.amount = amount;
            this.infractionType = infractionType;
            this.agent = agent;
        }

        // Propiedades
        public double Amount
        {
            get => amount;
            set => amount = value;
        }

        public string InfractionType
        {
            get => infractionType;
            set => infractionType = value;
        }

        public TrafficAgent Agent
        {
            get => agent;
            set => agent = value;
        }
    }
}