using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q39
    {
        public static void q39()
        {
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0 && i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
