namespace LibraryForTasks
{
    public class Variables
    {
        public static double Formula(int a, int b)
        {
            return (a + b) / a;
        }

        public static void Swap(ref int a, ref int b)
        {
            
            int temp = a;
            a = b;
            b = temp;
        }

        public static (double division, double reminder)
            DivisionAndModule(double a, double b)
        {
            return (a / b, a % b);
        }

        public static double Equation(double a, double b, double c)
        {
            return (c - b) / a;
        }
    }
}