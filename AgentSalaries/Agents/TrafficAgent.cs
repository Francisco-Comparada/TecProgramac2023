namespace AgentSalaries.Agents
{
    // clase agente de transito que hereda de agente 
    public class TrafficAgent : Agent
    {
        // Atributos
        private double baseAmount;
        private List<TrafficTicket> issuedTickets;

        // Constructor
        public TrafficAgent(int registrationNumber,
            string name,
            string position,
            DateTime dateOfAdmission,
            double baseAmount,
            List<TrafficTicket> issuedTickets) : base(registrationNumber,
            name,
            position,
            dateOfAdmission)
        {
            this.baseAmount = baseAmount;
            this.issuedTickets = issuedTickets;
        }

        // Propiedades
        public double BaseAmount
        {
            get => baseAmount;
        }

        public List<TrafficTicket> IssuedTickets
        {
            get => issuedTickets;
            set => issuedTickets = value;
        }

        // Metodo heredado pero con una implementacion particular
        public override double CalculateSalary()
        {
            // Calcular el monto total de los tickets del agente
            double totalAmount = 0.0;

            if (issuedTickets.Count != 0)
            {
                foreach (TrafficTicket ticket in issuedTickets)
                {
                    totalAmount += ticket.Amount;
                }
            }

            return BaseAmount + 0.1 * totalAmount;
        }
    }
}