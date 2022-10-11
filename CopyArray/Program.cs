using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            
            //int a = 10;
            //int b = 20;

            //b = a;
            //a = 999;
            //Console.WriteLine($"value of a is {a}");
            //Console.WriteLine($"value of b is {b}");

            //int[] a = { 1, 2, 3 };
            //int[] b = { 4, 5, 6 };

            //b = a;
            //b[0] = 999;
            //Console.WriteLine($"value of a is {a[0]}");
            //Console.WriteLine($"value of b us {b[0]}");

            //string name = "Kenan";
            //name = "Rufat";
            //for (int i = 0; i < 1000; i++)
            //{
            //    name = name + i;
            //}
            #endregion

            int[] source = { 1, 2, 4 };
            int[] target = { 7, 8, 3 };
            
            Array.Copy(source, target, source.Length);
            //source = target;
            source[1] = 999;

            Console.WriteLine("Target array");
            for (int i = 0; i < target.Length; i++)
            {
                Console.WriteLine(target[i]);
            }

            Console.WriteLine("Source array");

            for (int i = 0; i < source.Length; i++)
            {
                Console.WriteLine(source[i]);
            }

        }
    }
}
