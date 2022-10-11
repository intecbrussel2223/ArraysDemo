using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = {20.50m, 50.25m, 16.00m, 80.70m, 15.50m};
            
            Console.Write("Enter the price to search ");
            decimal price = decimal.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] == price)
                {
                    isFound = true;
                }
            }
            if (isFound)
            {
                Console.WriteLine("The price is found");
            }
            else
            {
                Console.WriteLine("The price is NOT found");
            }
        }


    }
}
