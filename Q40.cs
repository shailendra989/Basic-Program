using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q40
    {

     public static void perfectNumbers()
        {
            
            int sum = 0;
            Console.WriteLine("enter number  -:");
            int n =0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("please enter numerical value  ");
                return;
            }

            for(int i = 1;i< n;i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;  
                }
            }
            if (n == sum)
            {
                Console.WriteLine(n+" is perfect number ");
            }
            else
            {
                Console.WriteLine(n+" is not a perfect number ");
            }
        }

    }
}
