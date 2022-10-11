using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = {0,1,2,3};
            //int[] newArray = new int[array.Length+1];

            //newArray[4] = 4;
            //for (int i = 0; i < newArray.Length-1; i++)
            //{
            //    newArray[i] = array[i];
            //    Console.WriteLine(newArray[i]);
            //}
            //for (int i = 0; i < newArray.Length; i++)
            //{

            //    Console.WriteLine(newArray[i]);
            //}
            int[] array = { 0, 1, 2, 3 };
            Array.Resize(ref array, array.Length+1);
            array[4] = 4;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
