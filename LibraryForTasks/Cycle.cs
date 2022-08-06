using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTasks
{
    public class Cycle
    {
        public static void CwSumOfIntegers()
        {
            int sum = 0;
            for (int i = 100; i <= 300; i++)
            {
                sum += i;
            }
        }

        public static void CwCalculateSum()
        {
            double sum = 0;
            for (int i = 50; i >= 1; i--)
            {
                sum = Math.Sqrt(i + sum);
            }
        }

        public static void CwMultiplicationTable()
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

        public static void CwASKII()
        {
            char askiiChar;
            for (int i = 0; i < 128; i++)
            {
                askiiChar = (char)i;
            }
        }

        public static void CwDivisibleSum(int a, int b, int n)
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

        public static void CwPeterAndIceCream(int n, int k)
        {
            int IceCreams = 0;
            while (n >= k)
            {
                n -= k;
                ++IceCreams;
            }
        }

        public static int HwAtoPowerB(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static void HwDivisibleNumbers(int a)
        {
            int length = 1000;
            int result = 0;
            for (int i = 1; i <= length; i++)
            {
                if (i % a == 0)
                {
                    result = i;
                }
            }
        }

        public static double HwSquareNumberLessThanInput(double a)
        {
            int count = 0;
            while (count * count < a)
            {
                ++count;
            }

            return count != 0 ? count -1 : count;
        }

        public static int HwlargestDivisor(int a)
        {
             int result = 0;
            if (a % 2 == 0)
            {
                return a / 2;
            }

            for (int i = a / 2; i >= 1; i--)
            {
                if (a % i == 0)
                {
                  result = i;
                    break;
                }
            }

            return result;
        }

        public static int HwDivisibleSum(int a, int b)
        {
            int result = 0;
            int divider = 7;
            if (a > b)
            {
                Variables.Swap(ref a, ref b);
            }

            for (; a <= b; a++)
            {
                if (a % divider == 0)
                {
                    result += a;
                }
            }

            return result;
        }

        public static int HwFibonacciNumbers(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        public static int HwFindGreatestCommonDivisorEuclideanAlgorithm(int a, int b)
        {
            do
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            } while (a != b);

            return b;
        }

        public static void HwFindNByHalfDivision(int a)
        {
 
        }


    }
}
