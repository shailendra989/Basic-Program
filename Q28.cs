using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q28
    {
        public static void q28()
        {
            Console.WriteLine("write number - ");
            int i = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            //string r = string.Empty;
            int r = 0;
            int l = 10;
           while(i %10 != 0)
            {
                 x = i %10;
                r = (r * l)+x;
                
                //;r = r + x;
               
                i = i/10;


               
            }
            Console.WriteLine("reverse value is - :" + r);

        }
    }
}
