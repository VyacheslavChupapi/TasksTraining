using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTasks
{
    

    public class ConditionalOperators
    {
        public static bool EqualityСheck(int a)
        {
            return a <= 10;
        }

        public static bool MultiplicityСheck(int numeric, int divider)
        {
            if (numeric % divider == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int HourQuarter(int min)
        {
            int result = 0;

            if (min < 15)
            {
                result = 1;
            }
            else if (min < 30)
            {
                result = 2;
            }
            else if (min < 45)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }

            return result;
        }

        public static bool Triangle(double a, double b, double c)
        {
            return
                ((a + b) > c) &&
                ((a + c) > b) &&
                ((c + b) > a);
        }

        public static (double? x1, double? x2) QuadraticEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d == 0)
            {
                double x = -b / (2 * a);
                return (x, x);
            }
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                return (x1, x2);

            }
            else
            {
                return (null, null);
            }
        }

        public static bool LeapYear(int Year)
        {
            return Year % 4 == 0;
        }

        public static CharType LetterOrNot(char a)
        {
            if (char.IsLetter(a))
            {
                return CharType.Letter;
            }
            else if (char.IsDigit(a))
            {
                return CharType.Digit;
            }
            else
            {
                return CharType.Other;
            }
        }

        public static int EvenNumberActions(int a)
        {
            return (a % 2 == 0 && (a < 10 || a > 20)) ? a * a : a;
        }

        public static int MiddleDiggit(int a, int b, int c)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (a > c)
            {
                int temp = a;
                a = c;
                c = temp;
            }
            return b > c ? c : b;
        }
    }
}
