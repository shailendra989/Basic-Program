using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q37
    {
        public static void q37()
        {
            for(int i = 1;i<=30;i++) 
            {
                if (i % 3 == 0 && i % 9 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
