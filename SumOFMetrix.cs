using System;


namespace ArrayExample
{
    internal class SumOFMetrix
    {
        public static void sumOFMetrix()
        {
            int sum, row, col;
            Console.WriteLine("enter row");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("enter col");

            col = int.Parse(Console.ReadLine());

            int[,] metrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("enter element in metrix");
                    metrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(metrix[i, j] +" ");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += metrix[i, j];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
