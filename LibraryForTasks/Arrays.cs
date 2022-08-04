using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTasks
{
    public class Arrays
    {
        public static double CwGetMedianValueOfArray(int[] array)
        {
            int median = 0;
            for (int i = 0; i < array.Length; i++)
            {
                median += array[i];
            }

            return median / array.Length;
        }

        public static int CwGetPositiveNumbersCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    count++ ;
                }
            }

                return count;
        }

        public static void CwModifyArray(int[] array)
        {
            int SignSwapper= -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] *= SignSwapper;
                }
                else
                {
                    array[i] *= array[i];
                }
            }
        }

        public static int CwGetSumBetweenMinAndMaxElements(int[] array)
        {
            int minI = 0;
            int maxI = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxI])
                {
                    maxI = i;
                }

                if (array[i] < array[minI])
                {
                    maxI = i;
                }
            }

            int sum = 0;
            if (maxI > minI)
            {
                int temp = maxI;
                maxI = minI;
                minI = temp;
            }

            for (int i = minI; i < maxI; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] CwCreatePositiveNumbersArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                return null;
            }

                int[] positivesNumbersArray = new int[count];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    positivesNumbersArray[j++] = array[i];
                }
            }

            return positivesNumbersArray;
        }
    }
}
