using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program82
{
    internal class Program
    {
        static void Main()
        {
            bool result = ((20 >> 2) == 5) ^ ((5 << 1) == 11);
            Console.WriteLine(result); // True
        }
    }
}

