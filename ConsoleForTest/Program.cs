using LibraryForTasks;

namespace ConsoleForTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Cycle.HwDivisibleSum(a, b));

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"{i} = {Cycle.HwlargestDivisor(i)}");
            }

        }
    }
    
}