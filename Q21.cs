using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q21
    {
        public static void q21()
        {
            int sum = 0;
            for (int i =1;i<1000;i++)
            {
                if(i%2 == 0)
                {
                    sum += i;
                }
               
            }
            Console.WriteLine(sum);
          
        }
    }
}
