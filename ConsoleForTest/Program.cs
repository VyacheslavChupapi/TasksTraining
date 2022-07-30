using LibraryForTasks;

namespace ConsoleForTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.Write(a);
            }
            

        }
    }
    
}