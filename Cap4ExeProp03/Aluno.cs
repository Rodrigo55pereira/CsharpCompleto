using System;
using System.Globalization;

namespace Cap4ExeProp03
{
    public class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        private double NotaFinalAnual()
        {
            return nota1 + nota2 + nota3;
        }

        public void SituacaoAluno()
        {
            if (NotaFinalAnual() < 60.0)
            {
                double restante = 60.0 - NotaFinalAnual();
                Console.WriteLine("NOTA FINAL = "
                    + NotaFinalAnual().ToString("F2", CultureInfo.InvariantCulture)
                    + "\n"
                    + "REPROVADO"
                    + "\n"
                    + "FALTARAM " + restante.ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = "
                    + NotaFinalAnual().ToString("F2", CultureInfo.InvariantCulture)
                    + "\n"
                    + "APROVADO");
            }
        }
    }
}