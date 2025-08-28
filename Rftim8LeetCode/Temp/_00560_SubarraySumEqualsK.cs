﻿namespace Rftim8LeetCode.Temp
{
    public class _00560_SubarraySumEqualsK
    {
        /// <summary>
        /// Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
        /// A subarray is a contiguous non-empty sequence of elements within an array.
        /// </summary>
        public _00560_SubarraySumEqualsK()
        {
            Console.WriteLine(SubarraySum([1, 1, 1], 2));
            Console.WriteLine(SubarraySum([1, 2, 3], 3));
        }

        private static int SubarraySum(int[] nums, int k)
        {
            int n = nums.Length;
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                int y = 0;
                for (int j = i; j < n; j++)
                {
                    y += nums[j];
                    if (y == k) x++;
                }
            }

            return x;
        }
    }
}
