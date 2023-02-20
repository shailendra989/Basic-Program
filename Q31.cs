using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q31 { 
    
     public static void q31()
        {
            Console.WriteLine("put value");
            int answere = Convert.ToInt32(Console.ReadLine());
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {

                answere = answere * answere;
                Console.WriteLine(answere);

            }
         
        }   
    }
}
