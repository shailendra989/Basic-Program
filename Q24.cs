using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q24
    {
        public static  void  q24()
        {
            int x = 10; int y = 20;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("x is -"+x);
            Console.WriteLine("Y IS - " + y);


        }
    }
}
