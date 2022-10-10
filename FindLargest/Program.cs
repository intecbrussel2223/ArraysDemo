using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eersteNummer;
            int twedeNummer;
            int derdeNummer;
            Console.WriteLine("drie nummer inputen");
            Console.WriteLine("Eerste nummer?");
            eersteNummer = int.Parse(Console.ReadLine());
            Console.WriteLine("Twede nummer?");
            twedeNummer = int.Parse(Console.ReadLine());
            Console.WriteLine("Derde nummer?");
            derdeNummer = int.Parse(Console.ReadLine());
            Console.Clear();
            #region Fida


            //if (eersteNummer > twedeNummer && eersteNummer > derdeNummer)
            //{
            //    Console.WriteLine($"Grotste nummer is = {eersteNummer}");
            //}
            //else if (twedeNummer > eersteNummer && twedeNummer > derdeNummer)
            //{
            //    Console.WriteLine($"Grotste nummer is = {twedeNummer}");
            //}
            //else if (derdeNummer > eersteNummer && derdeNummer > twedeNummer)
            //{
            //    Console.WriteLine($"Grotste nummer is = {derdeNummer}");
            //}
            //else
            //{
            //    Console.WriteLine("Faut");
            //}
            #endregion

            int largest = int.MinValue;
            //int largest = 0;
            if (eersteNummer > largest)
            {
                largest = eersteNummer;
            }
            if(twedeNummer > largest)
            {
                largest=twedeNummer;
            }
            if (derdeNummer > largest)
            {
                largest = derdeNummer;
            }

            Console.WriteLine($"Grootste getal is {largest}");

        }
    }
}
