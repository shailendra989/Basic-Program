﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Q33
    {

        public static void q33()
        {
            Console.WriteLine("put a number -");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n % 10 != 0)
            {
                int r = n % 10;
                n = n / 10;
                if (r % 2 != 0)

                {
                    Console.WriteLine(r * r);
                }

            }
        }
    }
}   
