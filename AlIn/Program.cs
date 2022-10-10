using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region init


            //int[] array; // init array
            //int[] array = new int[5]; // init array
            //array[0] = 7; // geef de waardes aan een array
            //array[1] = 9;
            //array[2] = 3;
            //array[3] = 8;
            //array[4] = 5;
            ////array[5] = 8;

            //// loop en toon de waardes van array
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i==3)
            //    {
            //        array[3] = 18;
            //    }
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region init en loop

            //int[] array = { 7,9,3,8,5,6};
            //string[] names = {"Kenan", "Fida", "Sabrina", "Madalina", "Ilias","Mohammed","Peter" };
            //string[] cities = new string[3];
            //cities[0] = "Brussel";
            //cities[1] = "Antwerpen";
            //cities[2] = "Brugge";

            //for (int i = 0; i < names.Length; i++)
            //{

            //    if (i==0)
            //    {
            //        names[i] = "Jonas";
            //    }
            //    names[6] = "Rufat";
            //    Console.WriteLine(names[i]);
            //}

            //Console.WriteLine($"de index 5 is = {names[5]}");

            #endregion

            #region methods and properties

            int[] array = { 7, 9, 3, 8, 5, 6, 2,64,55,80,120 };
            Console.WriteLine(array.Length);
            Console.WriteLine(array[0]);
            Console.WriteLine($"this is the last element " +
                $"in the array {array[array.Length - 1]}");

            int secondPart = (array.Length / 2);
            Console.WriteLine(secondPart);

            for (int i = secondPart; i < array.Length; i++)
            {
                Console.WriteLine($"second part {array[i]}");
            }
            #endregion

            Console.WriteLine(new string('_',30));

            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
