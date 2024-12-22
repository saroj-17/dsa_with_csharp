using System;
using System.Globalization;

namespace SearchingTechniques
{
    class TwoPointerTechnique
    {
        public static bool TwoPointSum(int[] arr, int target)
        {
            int n= arr.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j=0; j<n-1; j++)
                {
                    int sum = arr[i]+arr[j];

                    if(sum == target)
                    {
                        return true;
                    }
                   
                }
            }
            return false; 
        }
    }
}