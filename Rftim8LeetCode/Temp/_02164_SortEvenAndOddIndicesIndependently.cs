﻿using Rftim8Convoy.Temp.Construct.Terminal;

namespace Rftim8LeetCode.Temp
{
    public class _02164_SortEvenAndOddIndicesIndependently
    {
        /// <summary>
        /// You are given a 0-indexed integer array nums. Rearrange the values of nums according to the following rules:
        /// Sort the values at odd indices of nums in non-increasing order.
        /// For example, if nums = [4, 1, 2, 3] before this step, it becomes [4,3,2,1] after.The values at odd indices 1 and 3 are sorted in non-increasing order.
        /// Sort the values at even indices of nums in non-decreasing order.
        /// For example, if nums = [4, 1, 2, 3] before this step, it becomes [2,1,4,3] after.The values at even indices 0 and 2 are sorted in non-decreasing order.
        /// Return the array formed after rearranging the values of nums.
        /// </summary>
        public _02164_SortEvenAndOddIndicesIndependently()
        {
            int[] x = SortEvenOdd([4, 1, 2, 3]);
            RftTerminal.RftReadResult(x);
            int[] x0 = SortEvenOdd([2, 1]);
            RftTerminal.RftReadResult(x0);
        }

        private static int[] SortEvenOdd(int[] nums)
        {
            int n = nums.Length;

            List<int> o = [];
            List<int> e = [];
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) e.Add(nums[i]);
                else o.Add(nums[i]);
            }

            o.Sort((a, b) => b.CompareTo(a));
            e.Sort();

            int[] r = new int[n];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (j < e.Count) r[i] = e[j];
                i++;
                if (j < o.Count) r[i] = o[j];
                j++;
            }

            return r;
        }
    }
}
