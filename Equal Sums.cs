using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers:");
            int[] arr = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
            bool mid = false;
            int n = arr.Length;

            Console.WriteLine("Index:");
            for (int i = 0; i < n; i++)
            {
                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += arr[k];
                }

                int rightSum = 0;
                for (int j = n - 1; j > i; j--)
                {
                    rightSum += arr[j];
                }

                if (leftSum == rightSum && !mid)
                {
                    Console.WriteLine(i);
                    mid = true;
                }
            }

            if (!mid)
            {
                Console.WriteLine("no");
            }
        }
    }
}
