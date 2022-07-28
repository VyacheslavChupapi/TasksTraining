using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTasks
{
    public class Cycle
    {
        public static void SumOfIntegers()
        {
            int sum = 0;

            for (int i = 100; i <= 300; i++)
            {
                sum += i;
            }
        }

        public static void CalculateSum()
        {
            double sum = 0;

            for (int i = 50; i >= 1; i--)
            {
                sum = Math.Sqrt(i + sum);
            }
        }

        public static void MultiplicationTable()
        {
            int result = 0;

            for (int j = 2; j <= 9; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    result = j * i;
                }
            }
        }

        public static void ASKII()
        {
            char askiiChar;

            for (int i = 0; i < 128; i++)
            {
                askiiChar = (char)i;
            }
        }

        public static void DivisibleSum(int a, int b, int n)
        {
            if (n != 0)
            {
                int sum = 0;

                a += (a % n != 0) ? (n - (a % n)) : 0;

                for (; a <= b; a += n)
                {
                    sum += a;
                }
            }
        }

        public static void PeterAndIceCream(int n, int k)
        {
            int IceCreams = 0;

            while(n >= k)
            {
               n -= k;
               ++IceCreams;
            }
        }

        // видеосос 02:42:30 досмотреть там задачи
    }
}
