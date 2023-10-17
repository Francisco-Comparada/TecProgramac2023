namespace AgentSalaries.Agents
{
    // clase agente de parulla que hereda de agente 
    public class PatrolAgent : Agent
    {
        // Atributos
        private string specialty;
        private string classification;
        private double baseAmount;
        private double variableAmount;

        // Constructor
        public PatrolAgent(int registrationNumber,
            string name,
            string position,
            DateTime dateOfAdmission,
            string specialty,
            string classification,
            double baseAmount,
            double variableAmount) : base(registrationNumber,
            name,
            position,
            dateOfAdmission)
        {
            this.specialty = specialty;
            this.classification = classification;
            this.baseAmount = baseAmount;
            this.variableAmount = variableAmount;
        }

        // Propiedades
        public string Specialty
        {
            get => specialty;
            set => specialty = value;
        }

        public string Classification
        {
            get => classification;
            set => classification = value;
        }

        public double BaseAmount
        {
            get => baseAmount;
        }

        public double VariableAmount
        {
            get => variableAmount;
        }


        // Metodo heredado
        public override double CalculateSalary()
        {
            // Calcular los meses de antiguedad
            DateTime today = DateTime.Today;
            int months = (today.Year - dateOfAdmission.Year) * 12 +
                         Math.Abs(today.Month - dateOfAdmission.Month);
            return baseAmount + months * variableAmount;
        }
    }
}