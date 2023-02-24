using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Circle
{
    static float PI;
    int radius;
    static Circle()
    {
        PI = 3.14f;
    }
    public Circle(int r)
    {
        radius= r;
    }
    public float CalculateArea()
    {
        return PI * radius * radius;
    }
}
namespace Static_and_Instance_members
{
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            Console.WriteLine("Area of C1 = " + C1.CalculateArea());

            Circle C2 = new Circle(6);
            Console.WriteLine("Area of C2 = " + C2.CalculateArea());
        }
    }
}
