using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 1000)
            {
                i += 5;
                Console.WriteLine("(0,5)", i);
                if (i % 50 == 0) Console.WriteLine(); 
            }
        }
    }
}
