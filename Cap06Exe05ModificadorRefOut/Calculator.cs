namespace Cap06Exe05ModificadorRefOut
{
    public class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void TripeOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}