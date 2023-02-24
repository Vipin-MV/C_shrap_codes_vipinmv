using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public string _fname;
    public string _lname;
    public string email;
    public void PrintName()
    {
        Console.WriteLine("Full Name is " + _fname + " " + _lname);
    }
}
class FullTimeEmployee:Employee
{
    public float yearly_salary;
}
namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE._fname = "Vipin";
            FTE._lname = "MV";
            FTE.email = "gulgul";
            FTE.yearly_salary = 2343.33f;
            Console.WriteLine(FTE._fname + " " + FTE._lname + " " + FTE.yearly_salary);
        }
    }
}
