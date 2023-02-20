using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q22
    {
        public static void q22()
        {
           int sum = 0;
            for(int i =0;i<10000;i++) 
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
