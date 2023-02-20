using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q23
    {
        public static void q23()
        {
            int temp;
            int x = 12; int y = 13;

            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("value of x - "+x);
            Console.WriteLine("value of y - " + y);
        }
    }
}
