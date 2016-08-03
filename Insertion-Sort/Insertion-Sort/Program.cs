using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSort<int> sorter = new InsertionSort<int>(new NonDecreasingIntegerComparer());
            int[] originalArray = { 27, 32, 1, 6, 95, 3 };

            Console.WriteLine("Original Array: {0}", IntegerArrayToString(originalArray));
            int[] sortedArray = sorter.Sort(originalArray);
            Console.WriteLine("Non Decreasing Sorted Array: {0}", IntegerArrayToString(sortedArray));
        }

        static String IntegerArrayToString(int[] array)
        {
            StringBuilder stringBuilder = new StringBuilder("[");

            foreach (int i in array) 
            {
                stringBuilder.AppendFormat("{0}, ", i);
            }
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }
    }

    class NonDecreasingIntegerComparer : IComparer<int>
    {
        /// <summary>
        /// Compara dos enteros ingresados
        /// </summary>
        /// <param name="x">Primer entero</param>
        /// <param name="y">Segundo entero</param>
        /// <returns>Regresa 0 si ambos enteros son iguales; 1 si x es mayor a y; -1 si x es menor a y</returns>
        public int Compare(int x, int y)
        {
            return x == y ? 0 : x > y ? 1 : -1;
        }
    }
}
