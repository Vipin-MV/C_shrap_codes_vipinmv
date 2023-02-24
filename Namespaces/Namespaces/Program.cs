using System;
using TA = ProjectA.TeamA ;
using TB = ProjectA.TeamB;

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            TA.ClassA.Print();
            TB.ClassA.Print();
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B");
            }
        }
    }
}
