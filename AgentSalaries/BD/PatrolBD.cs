using AgentSalaries.Agents;

namespace AgentSalaries.BD;

public class PatrolBD
{
    // Instanciar 3 objetos PatrolAgent

    public List<Agent> patrolBD()
    {
        // Salarios base y variable de los agente de patrulla
        double patrolAgent_baseAmount = 2500;
        double patrolAgent_variableAmount = 100;

        Agent agent1 = new PatrolAgent(1, "agente-1", "position-01",
            new DateTime(2022, 06, 20),
            "especialidad-100", "clasif-1", patrolAgent_baseAmount,
            patrolAgent_variableAmount);

        Agent agent2 = new PatrolAgent(2, "agente-2", "position-01",
            new DateTime(2022, 01, 20),
            "especialidad-200", "clasif-1", patrolAgent_baseAmount,
            patrolAgent_variableAmount);

        Agent agent3 = new PatrolAgent(3, "agente-3", "position-02",
            new DateTime(2020, 06, 20),
            "especialidad-100", "clasif-1", patrolAgent_baseAmount,
            patrolAgent_variableAmount);
        List<Agent> agentsList = new()
        {
            agent1,
            agent2,
            agent3,
        };
        return agentsList;
    }
}