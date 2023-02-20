using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q26
    {
        public static void q26()
        {
            Console.WriteLine("write number - ");
            int i = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            
            int numberCount = 0;
            while (i %10 != 0 )
            {
                if(i%2== 0)
                {
                    count++;
                }
               
                i = i / 10;
              //  count++;
                
            }
            Console.WriteLine(count);
        }
    }
}
