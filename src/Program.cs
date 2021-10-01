using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, 8, 9, 15, 19, 21, 23, 26, 35, 41, 67, 79, 82, 95, 97, 99 };
            string closingCmd = "exit";
            Console.WriteLine("Welcome! This is the Binary Search implemation using C#. \n");
            Console.WriteLine("Input any number between 0-99, we will find out index for you (if it is available in array).\n");
            Console.WriteLine("Type {0} to close.\n", closingCmd);

            do
            {
                Console.WriteLine(" ");
                Console.Write("Insert you desired number...");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int elm))
                {
                    int index = GetArrayIndexUsingBinarySearch(arr, elm);

                    if (index != -1)
                    {
                        Console.WriteLine("Element {0} found on index {1}\n", elm, index);
                    }
                    else
                    {
                        Console.WriteLine("Element {0} not found on index.\n", elm);
                    }
                }
                else if (userInput == closingCmd)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid text entered, try again with number.\n");
                }

            }
            while (true);
        }

        private static int GetArrayIndexUsingBinarySearch(int[] arr, int elm)
        {
            int left = 0;
            int right = arr.Length;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == elm)
                {
                    return mid;
                }
                if (elm < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
