using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 4, 1, 3, 5, 7, 0, 9, 2 };

            Array.Sort(arr);

            Console.WriteLine(BinarySearch(arr, 3).ToString()); // => 4
            Console.WriteLine(BinarySearch(arr, 4).ToString()); // => 5
            Console.WriteLine(BinarySearch(arr, -200).ToString()); // => None
            
            Console.ReadLine();
        }

        static object BinarySearch(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;

            int mid, guess;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = arr[mid];

                if (guess == item)
                    return mid;
                if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return "None";
        }
    }
}
