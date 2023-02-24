using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Customer
{
    string _fname;
    string _lname;
    public Customer(string first, string last)
    {
        _fname = first;
        _lname = last;
    }
    public void PrintName()
    {
        Console.WriteLine("Full Name is " + _fname + " " + _lname);
    }
}
namespace Intro_to_classes
{
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer("Vipin", "MV");
            C1.PrintName();
        }
    }
}
