using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q44
    {
        public static void q44()
        {
            Console.WriteLine("input a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            while (n % 10 !=0)
            {
               i = n% 10;
                if (i % 2 == 0)
                {
                    factorialNo(i);
                }
                n = n / 10;
               
                
            }
        }
        public static void factorialNo(int n)
        {
            int fact = 1;
            

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
