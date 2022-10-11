using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declaratie en/of initialisatie

            //int[] array = { 1, 2, 3 };
            //int[] array2 = new int[] { 1, 2, 3 };
            //int[] arrray3;
            //arrray3 = new int[] { 1, 2, 3 };
            //int[] array4 = new int[5];
            //array4[0] = 8;
            //array4[1] = 9;
            //array4[2] = 18;
            //array4[3] = 27;
            //array4[4] = 60;
            //array4[5] = 90;
            #endregion

            string[] cities = {"Brussel", "Antwerpen", "Gent", "Brugge" };

            Console.WriteLine(new string('_', 10));
            Console.WriteLine("for loop");
            Console.WriteLine(new string('_', 10));
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            Console.WriteLine(new string('_', 50));
            Console.WriteLine("while loop") ;
            Console.WriteLine(new string('_', 50));
            int x = 0;
            while (x<cities.Length)
            {
                Console.WriteLine(cities[x]);
                x++;
            }

        }
    }
}
