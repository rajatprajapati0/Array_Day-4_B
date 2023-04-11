using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExample
{
    internal class PrintAllUniqueElements
    {
        public static void printAllUniqueElements()
        {

            int[] arry = { 1, 2, 3, 2,0, 5, 5, 6 };
            
           


            for (int i = 0; i < arry.Length; i++)
            {
                bool duplicate = false; 
                for (int j = 0; j < i; j++)
                {

                    if (arry[i] == arry[j])
                    {
                        duplicate = true;
                        break;
                    }

                }
                if (!duplicate)
                {
                    Console.WriteLine(arry[i]);
                }


            }
            
        }
    }
}
