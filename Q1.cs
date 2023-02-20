using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
   internal class Q1
   {
        public  static void q1()
        {
            
                Console.WriteLine("Input a Numbers");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("Number is Postive");
                }
                if(number == 0)
                {
                Console.WriteLine("INVALID Number");

                }
                
                else
                {
                    Console.WriteLine("negative Number");
                }

            
        }

   }
}
