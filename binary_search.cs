using System;

namespace SearchingTechniques
{
    class BinarySearch
    {
        public static int Binary(int[] array, int low, int high, int key)
        {
            if (high >= low)
            {
                int mid = (high - low) / 2;

                //when the search is at middle 
                if (array[mid] == key)
                {
                    Console.WriteLine("Found at Middle in index" + mid);
                }

                else if (array[mid] < key)
                {
                    return Binary(array, low, mid - 1, key);
                }
                else
                {
                    return Binary(array, mid + 1, high, key);
                }

            }
            return -1;
        }
    }
}