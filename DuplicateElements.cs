using System;

/*1) Write a program in C# Sharp to count a total number of duplicate elements
in an array.*/
namespace ArrayExample
{
    internal class DuplicateElements
    {
        public static void duplicateElements()
        {
            int[] arry = {1,2, 3, 0, 5,5,2};
            int count=0;
            int i,j;
    

            for ( i = 0; i < arry.Length; i++)
            {

                for (j = i+1; j < arry.Length; j++) 
                {

                    if (arry[i] == arry[j]) 
                    {
                        count++;
                        break;
                    }
                
                }
            
            }
            Console.WriteLine($"total number of duplicate elements in an array{count}");


        }
    }
}
