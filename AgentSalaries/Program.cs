using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentSalaries.Agents;

namespace AgentSalaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Salarios base y variable de los agente de patrulla
            double patrolAgent_baseAmount = 2500;
            double patrolAgent_variableAmount = 100;

            // Salario base de los agentes de transito
            double trafficAgent_baseAmount = 3000;

            // Instanciar 3 objetos PatrolAgent
            Agent agente1 = new PatrolAgent(1, "agente-1", "position-01", new DateTime(2022, 06, 20), "especialidad-100", "clasif-1", patrolAgent_baseAmount, patrolAgent_variableAmount);

            Agent agente2 = new PatrolAgent(1, "agente-2", "position-01", new DateTime(2022, 01, 20), "especialidad-200", "clasif-1", patrolAgent_baseAmount, patrolAgent_variableAmount);

            Agent agente3 = new PatrolAgent(1, "agente-3", "position-02", new DateTime(2020, 06, 20), "especialidad-100", "clasif-1", patrolAgent_baseAmount, patrolAgent_variableAmount);

            // Definir e inicializar una lista de tickets para el agente numero 4
            List<TrafficTicket> tickets_agent04 = new();

            // Instanciar 1 TrafficAgent usando la Lista de tickets como parametro  
            Agent agente4 = new TrafficAgent(1, "agente-4", "position-02", new DateTime(2020, 06, 20), trafficAgent_baseAmount, tickets_agent04);

            // Cargar la Lista con tickets
            tickets_agent04.Add(new TrafficTicket(100.50, "Exceso de velocidad", agente4));
            tickets_agent04.Add(new TrafficTicket(233.50, "Exceso de velocidad", agente4));

            // Crear una lista de objetos agentes
            List<Agent> agentsList = new()
            {
                agente1,
                agente2,
                agente3,
                agente4
            };

            // Calcular el salario de cada agente en la lista de agentes
            foreach (Agent agent in agentsList)
            {
                Console.WriteLine("Agente: " + agent.Name + " Salario: $" + agent.CalculateSalary());
            }

        }

    }
}