namespace AgentSalaries.Agents
{
    // Clase padre para que representa de forma general a los agentes 
    public abstract class Agent
    {
        // Atributos
        protected int registrationNumber;
        protected string name;
        protected string position;
        protected DateTime dateOfAdmission;


        /* Por mas que la clase sea abstracta, defino el constructor para inicializar
         * el objeto TodoO en una linea y no tener que hacerlo con un set. */

        public Agent(int registrationNumber, string name, string position,
            DateTime dateOfAdmission
        )
        {
            this.registrationNumber = registrationNumber;
            this.name = name;
            this.position = position;
            this.dateOfAdmission = dateOfAdmission;
        }

        // Propiedades
        public int RegistrationNumber
        {
            get => registrationNumber;
            set => registrationNumber = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public DateTime DateOfAdmission
        {
            get => dateOfAdmission;
            set => dateOfAdmission = value;
        }

        //Polimorfismo para que sus clases hijas tengan el mismo nombre del metodo pero distintos codigos 
        public abstract double CalculateSalary();
    }
}