using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q16
    {
        public static void  q16() { 
        int sum = 0;
            for (int i = 35; i >= 11; i--)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            } 
                    Console.WriteLine(sum);


        }
    }
}
