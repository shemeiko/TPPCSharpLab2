using System;

namespace Tasks
{
    public class Task1
    {
        static double SumBetweenPositives(double[] arr)
        {
            int firstIdx = -1, secondIdx = -1;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 0)
                {
                    if (firstIdx == -1) firstIdx = i;
                    else
                    {
                        secondIdx = i;
                        break;
                    }
                }
            }

            if (secondIdx == -1) return 0;

            double sum = 0;
            for (int i = ++firstIdx; i < secondIdx; ++i) sum += arr[i];

            return sum;
        }

        static double[] ShiftZerosRight(double[] arr)
        {
            return arr.Where(x => x != 0)
              .Concat(arr.Where(x => x == 0))
              .ToArray();
        }

        public static void Run()
        {
            Console.Write("Size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Array size should be greater than 0");
                return;
            }

            double[] arr = new double[n];

            for (int i = 0; i < n; ++i)
            {
                Console.Write($"Enter arr[{i}] element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nMax element: {0}", arr.Max(e => Math.Abs(e)));
            Console.WriteLine("Sum between two positive nums: {0}", SumBetweenPositives(arr));
            double[] new_arr = ShiftZerosRight(arr);
            foreach (double num in new_arr)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}