using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, -4, 44, 2, 3, 4, 18, 42, 111, -24, 2, 92, 324, 1, -3, 5, 7, 0, 9, 2 };


            PrintArray(arr);

            SelectionSort(ref arr);

            PrintArray(arr);

            Console.ReadLine();
        }

        static void SelectionSort(ref int[] arr) 
        {
            int temp, smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
     

        static void PrintArray(int[] arr) 
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.Write("]\n");

        }
    }
}
