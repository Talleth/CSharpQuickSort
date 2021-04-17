using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] pArguments)
        {
            // Initialize variables
            int[] randomArray = Program.RandomNumberGenerator(1000);

            // Print unsorted numbers
            Console.WriteLine();
            Console.WriteLine("Unsorted numbers:");
            Console.WriteLine();
            Program.PrintArray(randomArray);
            Console.WriteLine();

            // Call quick sort algorithm
            Program.QuickSort(randomArray, 0, randomArray.Length - 1);

            // Print sorted numbers
            Console.WriteLine();
            Console.WriteLine("Sorted numbers:");
            Console.WriteLine();
            Program.PrintArray(randomArray);
        }

        public static void PrintArray(int[] arrayToPrint)
        {
            // Simple function to print data in an array
            string valueToPrint = string.Empty;

            foreach (int value in arrayToPrint)
                valueToPrint += value.ToString() + ",";

            Console.WriteLine(valueToPrint.TrimEnd(','));
        }

        public static int[] RandomNumberGenerator(int numberOfNumbers)
        {
            // Initialize output array and random number class
            int[]   result = new int[numberOfNumbers];
            Random  random = new Random();

            // Get each random number and store in array
            for (int i = 0; i < numberOfNumbers; i++)
                result[i] = random.Next(1, numberOfNumbers);

            return result;
        }

        private static void QuickSort(int[] arrayToSort, int left, int right)
        {
            // Main quicksort logic
            // Function splits array sorts and splits recursively
            if (left < right)
            {
                int pivot = Split(arrayToSort, left, right);

                if (pivot > 1)
                    Program.QuickSort(arrayToSort, left, pivot - 1);
                if (pivot + 1 < right)
                    Program.QuickSort(arrayToSort, pivot + 1, right);
            }
        }

        private static int Split(int[] arrayToSort, int left, int right)
        {
            int pivot = arrayToSort[left];

            // Determine which way to pivot on split
            // Return pivot

            while (true)
            {
                while (arrayToSort[left] < pivot)
                    left++;

                while (arrayToSort[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (arrayToSort[left] == arrayToSort[right])
                        return right;
                    else
                    {
                        int tempValue = arrayToSort[left];

                        arrayToSort[left]   = arrayToSort[right];
                        arrayToSort[right]  = tempValue;
                    }
                }
                else
                    return right;
            }
        }
    }
}
