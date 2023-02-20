using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q29
    {
        public static void q29()
        {
            int r;
            int sum = 0;
            int temp = 0;

            int n = 454;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("pallandrome number");
            }
            else
            {
                Console.WriteLine("not pallandrone number");
            }


        }

        
    }
}
