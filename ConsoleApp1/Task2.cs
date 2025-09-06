using System;

namespace Tasks
{
    public class Task2
    {
        public static void Run()
        {
            Console.Write("Number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Array arr = Array.CreateInstance(typeof(int), rows, cols);

            var rand = new Random();

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j) arr.SetValue(rand.Next(100), i, j);

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j) Console.Write("{0} ", arr.GetValue(i, j));
                Console.WriteLine();
            }

            int max = int.MinValue;
            int maxRow = -1, maxCol = -1;

            for (int j = 0; j < cols; ++j)
            {
                int min = int.MaxValue;
                int minRow = -1;
                for (int i = 0; i < rows; ++i)
                {
                    int val = (int)arr.GetValue(i, j)!;
                    if (val < min)
                    {
                        min = val;
                        minRow = i;
                    }
                }

                if (max < min)
                {
                    max = min;
                    maxCol = j;
                    maxRow = minRow;
                }
            }

            Console.WriteLine("\nHighest number based on minimum col elements: {0}", max);
            Console.WriteLine($"Row: {maxRow+1}, Column: {maxCol+1}");
        }
    }
}