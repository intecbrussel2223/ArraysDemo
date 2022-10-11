using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Jan", "Tina", "Ann", "Tim","Zeki"};
            int[] marks = {9,7,10,6,8 };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]+" "+marks[i]);
            }
        }

    }
}
