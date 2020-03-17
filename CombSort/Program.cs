using System;
using System.Collections.Generic;

namespace CombSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const double factor = 1.247;
            List<int> array = new List<int>() {3, 5, 2, 6, 4, 1, 9, 8, 7};
            decimal distance = Math.Round((decimal) (array.Count / factor));
            while (distance >= 1)
            {
                for (int i = 0; i + distance < array.Count; i++)
                {
                    if (array[i] > array[(int) (i + distance)])
                    {
                        int temp = array[(int) (i + distance)];
                        array[(int) (i + distance)] = array[i];
                        array[i] = temp;
                    }
                }
                distance /= (decimal) factor;
            }
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = 0; j < array.Count - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}