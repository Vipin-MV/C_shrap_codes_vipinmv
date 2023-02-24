using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evens = new int[3];
            evens[0] = 0;
            evens[1] = 2;
            evens[2] = 4;
            int[] odds = { 1, 3, 5 };
            Console.WriteLine(evens[0] + odds[1]);
        }
    }
}
