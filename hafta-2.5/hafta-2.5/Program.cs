using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 195;
            int y = 26;
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
            Console.WriteLine("x={0}\ny={1}\n", x, y);
        }
    }
}
