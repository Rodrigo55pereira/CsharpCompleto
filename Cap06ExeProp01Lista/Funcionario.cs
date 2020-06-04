using System.Globalization;

namespace Cap06ExeProp01Lista
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void AumentarSalario(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}