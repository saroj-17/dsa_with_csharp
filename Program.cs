using System;

namespace SearchingTechniques
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int key = 5;

            int result = LinearSearch.Search(arr, arr.Length, key);
            int binary_result = BinarySearch.Binary(arr,0,5,3);

            if (result == -1)
            {
                Console.WriteLine("Element is not present at array");

            }
            else
            {
                Console.WriteLine("Element is present at Index:" + result);
                Console.WriteLine("Using Binary search found at"+binary_result);

            }

        }

    }

}

