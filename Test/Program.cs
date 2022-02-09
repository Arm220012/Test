using System;

namespace Test
{
    class Swap
    {
        public static int MinimumSwaps(int[] arr)
        {
            int count = 0;
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] != i + 1)
                {
                    while (arr[i] != i + 1)
                    {
                        int temp = 0;
                        temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        count++;
                    }
                }
                i++;
            }
            return count;
        }

    }
    class Toys
    {
        public static int MaximumToys(int[] cost, int N, int K)
        {
            int count = 0;
            int sum = 0;
            Array.Sort(cost);
            for (int i = 0; i < N; i++)
            {
                if (sum + cost[i] <= K)
                {
                    sum = sum + cost[i];
                    count++;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////Left Rotation

            string[] nd = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));

            Console.Write("After rotation array is  ");
            for (int i = d; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < d; i++)
            {
                Console.Write($"{arr[i]} ");
            }


            ///Minimum Swaps

            //int[] arr = { 2, 3, 4, 1, 5 };
            //Console.WriteLine(Swap.MinimumSwaps(arr));

            ///Max Toys Count

            //int K = 30;
            //int[] cost = { 1, 12, 5, 111, 200, 1000, 10, 9, 12, 15 };
            //int N = cost.Length;
            //Console.WriteLine(Toys.MaximumToys(cost, N, K));
        }
    }

}