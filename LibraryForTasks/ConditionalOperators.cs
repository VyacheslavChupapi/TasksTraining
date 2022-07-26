﻿using System;
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
            return numeric % divider == 0;
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

        public static EnumCharType LetterOrNot(char a)
        {
            if (char.IsLetter(a))
            {
                return EnumCharType.Letter;
            }
            else if (char.IsDigit(a))
            {
                return EnumCharType.Digit;
            }
            else
            {
                return EnumCharType.Other;
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

        public static int Сomparison(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }

        public static EnumQuarterСoordinates PointCoordinates(int x, int y)
        {
            if (x > 0 || y > 0)
            {
                return EnumQuarterСoordinates.First;
            }
            else if (x > 0 || y < 0)
            {
                return EnumQuarterСoordinates.Second;
            }
            else if (x < 0 || y < 0)
            {
                return EnumQuarterСoordinates.Third;
            }
            else
            {
                return EnumQuarterСoordinates.Fourth;
            }
        }

        public static void NumbersInAscendingOrder(ref int a, ref int b, ref int c)
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
            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }
        }


    }
}
