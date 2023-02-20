using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q41
    {
        public static void factorialNo()
        {
            int fact = 1;
            Console.WriteLine("input a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1 ; i <= n; i++)
            {
                fact = fact * i;    
            }
            Console.WriteLine(fact);
        }
    }
}
