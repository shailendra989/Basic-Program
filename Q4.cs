using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q4
    {
        public static void q4()
        {
            Console.WriteLine("Input a Numbers");
            int numberValue = Convert.ToInt32(Console.ReadLine());

            if(numberValue == 8 || numberValue== 10 || numberValue == 11) 
            {
                Console.WriteLine("good morning");
            }
            else
            {
                Console.WriteLine("bad morning");
            }

        }
    }
}
