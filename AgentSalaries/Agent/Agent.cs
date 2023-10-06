using AgentSalaries.Administrative;

namespace AgentSalaries.Agent;

// Clase padre para que representa de forma general a los agentes 
public abstract class Agent
{
    private int registrationNumber { get; set; }
    private string name { get; set; }
    private string position { get; set; }
    private DateTime dateOfAdmission { get; set; }
  


    // Por mas que sea abstract le pongo constructor para inicializar
    // el objeto todo_ en una linea y no tener que hacerlo con un set
    protected Agent(int registrationNumber, string name, string position, DateTime dateOfAdmission
       )
    {
        this.registrationNumber = registrationNumber;
        this.name = name;
        this.position = position;
        this.dateOfAdmission = dateOfAdmission;
      
    }

    //Polimorfismo para que sus clases hijas tengan el mismo nombre del metodo pero distintos codigos 
    public abstract double CalculateSalary();
}