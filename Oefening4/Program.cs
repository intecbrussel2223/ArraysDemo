using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 45, 8, 45, 58, 60, 49, 70, 90, 12, 50, 800, 700, 3, 900 };
            int a = 10;
            int b = 200;
            //int[] array2 = new int[array.Length];
            int[] array2 = array;
            b = 500;
            for (int i = 0; i < array.Length; i++)
            {
                //array2[i] = array[i];
                Console.WriteLine($"array 2 element {array[i]}");
            }
            array2[3] = 999;

            Console.WriteLine($" {array2[3]} {array[3]}" );
            Console.WriteLine($" {a} {b}" );

        }
    }
}
