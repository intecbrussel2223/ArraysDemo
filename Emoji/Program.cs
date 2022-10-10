using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { '\u263A', '\u263B' };


            foreach (var item in chars)
            {
                Console.WriteLine(item);

            }


        }
    }
}
