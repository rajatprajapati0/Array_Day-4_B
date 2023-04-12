using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExample
{
    internal class PyramidPattern
    {
        public static void pyramidPattern() 
        {
            for(int i = 0; i < 10; i++)
            {
               for (int j = i; j < 10; j++)
               {
                    Console.Write("*");
               }
                Console.WriteLine();
            }
            Console.WriteLine("||||||||||||||");
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j >=0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
