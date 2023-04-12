using System;


namespace ArrayExample
{
    internal class FindMaximumAndMinimumElement
    {
      
        public static void findMaximumAndMinimumElement()
        {

            int max = 0;
            int minimum = 0;
            int[] arr = { 1, 2,6,5,};

            for(int i  = 0; i < arr.Length; i++) 
            {
                
                if (arr[i] >= max)
                { 
                   max = arr[i];
                
                }              
            }
            minimum = max;
            for (int i = 0; i < arr.Length; i++)
            {
               

                if (arr[i] <= minimum)
                {
                    minimum = arr[i];

                }
            }

            Console.WriteLine($"Maximum value:{max}\nMinimum value:{minimum}");

        }
    }
}
