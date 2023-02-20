using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q25
    {
        public static void q25()
        {
            Console.WriteLine("write number - ");
            int i = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (i % 10 != 0)
            {
                i = i / 10;
                count++;
            }
            Console.WriteLine(count);
        }
        
    }
}
