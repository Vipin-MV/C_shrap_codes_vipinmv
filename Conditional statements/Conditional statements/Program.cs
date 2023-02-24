using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            if (f==1)
                Console.WriteLine("f is 1");
            int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(c);
            switch (c)
            { 
                case 1:
                    Console.WriteLine("c is one");
                    break;
                case 2:
                    Console.WriteLine("c is two");
                    break;
                default:
                    Console.WriteLine("Went into default");
                    break;
            }

        }
    }
}
