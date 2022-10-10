using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 45, 8, 45, 58, 60, 49, 70, 90, 12,50,800,700,3,900};

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Maximum is {max}");
            Console.WriteLine($"Minimum is {min}");
        }
    }
}
