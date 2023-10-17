using AgentSalaries.Agents;

namespace AgentSalaries.BD;

public class TrafficBD
{
    public List<Agent> traficBD()
    {
        // Salario base de los agentes de transito
        double trafficAgent_baseAmount = 3000;

        // Definir e inicializar una lista de tickets para el agente numero 4
        List<TrafficTicket> tickets_agent04 = new();

        // Instanciar 1 TrafficAgent usando la Lista de tickets como parametro  
        TrafficAgent agent4 = new TrafficAgent(4, "agente-4", "position-02",
            new DateTime(2020, 06, 20),
            trafficAgent_baseAmount, tickets_agent04);

        // Cargar la Lista con tickets
        tickets_agent04.Add(new TrafficTicket(100.50, "Exceso de velocidad",
            agent4));
        tickets_agent04.Add(new TrafficTicket(233.50, "Exceso de velocidad",
            agent4));
        List<Agent> agentsList = new()
        {
            agent4
        };
        return agentsList;
    }
}