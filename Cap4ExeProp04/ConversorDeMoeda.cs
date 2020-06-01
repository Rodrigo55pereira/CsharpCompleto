namespace Cap4ExeProp04
{
    public class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double ValorPagorEmReais(double cotacao, double quantidade)
        {
            double valor = cotacao * quantidade;
            return valor + valor * (IOF / 100.0);
        }
    }
}