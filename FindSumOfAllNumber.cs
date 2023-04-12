using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExample
{
    internal class FindSumOfAllNumber
    {
        public static void findSumOfAllNumber() 
        {
            int n;
            int sum=0;
            Console.WriteLine("Size of number");
            n=int.Parse(Console.ReadLine());
            int[] arry = new int[n];
            for(int i = 0; i < arry.Length; i++) 
            {
                Console.WriteLine("enter no.");
                arry[i] = int.Parse(Console.ReadLine());
            
            }
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i]+",");
            }
            Console.WriteLine();
            for (int i = 0; i < arry.Length; i++)
            {
              sum+= arry[i];

            }
            Console.WriteLine(sum);


        }
    }
}
