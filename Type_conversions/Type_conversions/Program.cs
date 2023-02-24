using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_conversions
{
    class Program
    {
        static void Main()
        {
            float f = 123f;
            int i = (int)f;
            int j = Convert.ToInt32(f);
            string s = "122jvjmgv2";
            int res;
            bool b=int.TryParse(s,out res);
            string s1 = "122";
            int l = int.Parse(s1);
            if (l == 122 && b == true)
                Console.WriteLine("Yes"+b+res);
            else
                Console.WriteLine("No"+b+res);
        }
    }
}
