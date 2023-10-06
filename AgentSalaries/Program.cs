// See https://aka.ms/new-console-template for more information

using AgentSalaries.Administrative;
using AgentSalaries.Agent;
//PRUEBAS -- SACO BASE SALARY DE ACA NO TIENDE SENTIDO, CONVIENE LLAAMRLO DE LAS CLASE EN EL METODO
//LO SACO COMO ATRIBUTO DE CLASE
Console.WriteLine("Hello, World!");
double patrolSalary = BaseSalary.baseSalaryPatrol;
DateTime now = DateTime.Now;
PatrolAgent agent = new PatrolAgent(40,"fran","transit",now,
    "agenfsd","dsjffjk","30");
    Console.WriteLine("Agent: " + agent.CalculateSalary());