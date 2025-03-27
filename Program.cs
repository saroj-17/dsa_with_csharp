using System;
using System.Collections;
using dsa_with_csharp;

namespace SearchingTechniques
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int key = 5;
            int target = 9;

            //for binary search 
            int result = LinearSearch.Search(arr, arr.Length, key);
            int binary_result = BinarySearch.Binary(arr, 0, 5, 3);

            if (result == -1)
            {
                Console.WriteLine("Element is not present at array");

            }
            else
            {
                Console.WriteLine("Element is present at Index:" + result);
                Console.WriteLine("Using Binary search found at" + binary_result);
            }
            //for two point array technique
            bool output = TwoPointerTechnique.TwoPointSum(arr, target);
            if (output)
            {
                Console.WriteLine("Two point sum is found");

            }
            else
            {
                Console.WriteLine("Unable to find two point sum");
            }

            //fot two point array technique with hasing and binary search 

            bool result1 = SearchingTechniques.TwoPointerSumHashing.TwoPointerSumWithHasing(arr, target);
            if (result1)
            {
                Console.WriteLine("Sum of two integer is found");
            }
            else
            {
                Console.WriteLine("Sum of the array is not found using hasing with two point sum");
            }

            //for queue datastructure 
            Queue1<int> queue = new Queue1<int>(5); 

            try
            {
                queue.Enqueue1(10); 
                queue.Enqueue1(20); 
                queue.Enqueue1(30); 
                queue.Enqueue1(40); 
                queue.Enqueue1(50); 


                //display 
                queue.Display(); 

                queue.Dequeue1(); 
                queue.Dequeue1(); 

                queue.Display(); 

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured at {e.Message}");
            }

            //stack 

            Stack1 s = new Stack1(5); 
            s.Push(20); 
            s.Push(30); 
            s.Push(50); 

            s.Display(); 
            s.Pop(); 
            s.Pop(); 

            s.Push(70); 
            s.Push(80); 
            s.Push(90);

            s.Display(); 

        }

    }

}

