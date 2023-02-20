using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q30
    {
        public static void q30()
        {
            int r;
            int sum = 0;
            int temp = 0;


           
            for (int i = 10; i < 100; i++)
            {
                while (i > 0)
                {
                    r = i % 10;
                    sum = (sum * 10) + r;
                    i = i / 10;
                }
            }
            if(temp  == sum)
            {
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("------");
            }
        }
    } 
}
