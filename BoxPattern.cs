using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExample
{
    internal class BoxPattern
    {
        public static void boxPattern()
        {
            int widththOFBox = 10;

            int lengthOFBox = 10;

            Console.WriteLine("\n");
            for (int i = 1; i <= lengthOFBox; i++)
            {  
               for(int j = 1; j <= widththOFBox; j++) 
               {
                    if (i==1||i==10||j==1||j==widththOFBox)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                
               }
                Console.WriteLine();
            }

        }
    }
}
