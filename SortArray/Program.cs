using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 1, 4, 1, 6, 7, 8, 2, 6, 2 };
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
