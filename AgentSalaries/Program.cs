using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentSalaries.Agents;
using AgentSalaries.BD;

namespace AgentSalaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Agent> agentsList = new List<Agent>();
            agentsList.AddRange(new PatrolBD().patrolBD());
            agentsList.AddRange(new TrafficBD().traficBD());
            foreach (Agent agent in agentsList)
            {
                Console.WriteLine("Agente: " + agent.Name + " |Numero de matricula: " +
                                  agent.RegistrationNumber + " |Posicion " +
                                  agent.Position + " |Fecha de ingreso " +
                                  agent.DateOfAdmission + " |Salario: $" +
                                  agent.CalculateSalary());
            }
        }
    }
}