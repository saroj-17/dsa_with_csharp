using System;
namespace SearchingTechniques
{
    class TwoPointerSumHashing
    {
        public static bool TwoPointerSumWithHasing(int[] arr, int key)
        {
            Array.Sort(arr);

            int left = 0;
            int right = arr.Length - 1;
            int sum = arr[left] + arr[right];

            while (left < right)
            {
                if (sum == key)
                {
                    return true;
                }
                else if (sum < key)
                {
                    left++;

                }
                else
                {
                    right--;
                }

            }


            return false;
        }
    }
}