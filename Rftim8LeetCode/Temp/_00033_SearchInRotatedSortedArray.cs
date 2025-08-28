﻿namespace Rftim8LeetCode.Temp
{
    public class _00033_SearchInRotatedSortedArray
    {
        /// <summary>
        /// There is an integer array nums sorted in ascending order (with distinct values).
        /// Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k(1 <= k<nums.length) 
        /// such that the resulting array is [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0-indexed). 
        /// For example, [0, 1, 2, 4, 5, 6, 7] might be rotated at pivot index 3 and become[4, 5, 6, 7, 0, 1, 2].
        /// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
        /// You must write an algorithm with O(log n) runtime complexity.
        /// </summary>
        public _00033_SearchInRotatedSortedArray()
        {
            Console.WriteLine(SearchInRotatedSortedArray0([4, 5, 6, 7, 0, 1, 2], 0));
            Console.WriteLine(SearchInRotatedSortedArray0([4, 5, 6, 7, 0, 1, 2], 3));
            Console.WriteLine(SearchInRotatedSortedArray0([1], 0));
            Console.WriteLine(SearchInRotatedSortedArray0([1, 3], 3));
        }

        public static int SearchInRotatedSortedArray0(int[] a0, int a1) => RftSearchInRotatedSortedArray0(a0, a1);

        private static int RftSearchInRotatedSortedArray0(int[] nums, int target)
        {
            int n = nums.Length;
            int x = -1, l = 0, r = n - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target) { x = mid; break; }
                else if (nums[l] <= nums[mid])
                {
                    if (nums[l] <= target && target <= nums[mid]) r = mid - 1;
                    else l = mid + 1;
                }
                else
                {
                    if (nums[mid] <= target && target <= nums[r]) l = mid + 1;
                    else r = mid - 1;
                }
            }

            return x;
        }
    }
}
