using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main()
        {
            int res;
            bool b = int.TryParse(Console.ReadLine(),out res);
            if (b == false)
                Console.WriteLine("Enter correct stuff bro :(");
            else
            {
                int a = res;
                while(res>0)
                {
                    Console.Write(res + " ");
                    res -= 2;
                }
                Console.WriteLine(" ");
                res = a;
                do
                {
                    Console.Write(res + " ");
                    res -= 2;
                } while (res > 0);
                Console.WriteLine(" ");
                res = a;
                for(int i=res;i>0;i-=2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
            }
            int[] evens = { 10, 8, 6, 4, 2 };
            foreach(int i in evens)
            {
                Console.Write(i + " ");
            }
        }
    }
}
