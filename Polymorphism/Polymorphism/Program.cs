using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//base class variable can point ot child class variable
class Employee
{
    public string _lname="LN";
    public string _fname="FN";
    public virtual void PrintName()
    {
        Console.WriteLine("Full Name is " + _fname + " " + _lname);
    }
}
class FullTimeEmployee:Employee
{
    public override void PrintName()
    {
        Console.WriteLine("Full Name is " + _fname + " " + _lname+" full");
    }
}
class PartTimeEmployee : Employee
{
    public override void PrintName()
    {
        Console.WriteLine("Full Name is " + _fname + " " + _lname +" part");
    }
}
class TempEmployee : Employee
{
    public override void PrintName()
    {
        Console.WriteLine("Full Name is " + _fname + " " + _lname+ " temp");
    }
}
namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TempEmployee();

            foreach (Employee emp in employees)
            {
                emp.PrintName();
            }

        }
        
    }
}
