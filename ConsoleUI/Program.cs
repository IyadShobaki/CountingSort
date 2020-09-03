using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Only work with non-negative discrete values (can't work with floats, strings)
            // Values within a specific range (not huge range)
            // Not in-place algorithm
            // O(n) TC
            // Unstable unless wo do extra steps to make it stable

            int[] intArray = { 2, 5, 9, 8, 2, 8, 7, 10, 4, 3 };

            CountingSort(intArray, 1, 10);

            Console.WriteLine(string.Join(" ", intArray));
            Console.ReadLine();

        }

        public static void CountingSort(int[] input, int min, int max)
        {
            
            int[] countArray = new int[(max - min) + 1];

            // Counting phase
            for (int i = 0; i < input.Length; i++)
            {
                // example: countArray[input[0] - 1]++;
                // example: countArray[2 - 1]++;
                // example: countArray[1]++;  (countArray[1] = 0 + 1)
                countArray[input[i] - min]++;
            }

            // Write the values back to the input array
            int j = 0; // the index to write to the input array

            for (int i = min; i <= max; i++)
            {
                // example i = 2
                // countArray[2 - 1] = 2
                while (countArray[i - min] > 0) 
                {
                    input[j++] = i;
                    countArray[i - min]--;
                }
            }
        }
    }
}
