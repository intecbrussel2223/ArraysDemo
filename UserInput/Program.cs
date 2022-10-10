using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks;
            int som = 0;
            Console.Write("Bepaal de grote van de array ");
            int n = int.Parse(Console.ReadLine());
            marks = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Geef de waardes van de punten ");

                marks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Wardes in de array ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"punt {i+1} is {marks[i]}");
                som +=marks[i];
            }
            Console.WriteLine($"Gemiddelde punt is {som / n}");
        }
    }
}
