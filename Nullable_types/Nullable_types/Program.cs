using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_types
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int? n = null;
            if (n == null)
                Console.WriteLine("n is NULL");
        }
    }
}
