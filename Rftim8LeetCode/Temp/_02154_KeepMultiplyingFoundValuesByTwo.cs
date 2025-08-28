﻿namespace Rftim8LeetCode.Temp
{
    public class _02154_KeepMultiplyingFoundValuesByTwo
    {
        /// <summary>
        /// You are given an array of integers nums. You are also given an integer original which is the first number that needs to be searched for in nums.
        /// You then do the following steps:
        /// If original is found in nums, multiply it by two(i.e., set original = 2 * original).
        /// Otherwise, stop the process.
        /// Repeat this process with the new number as long as you keep finding the number.
        /// Return the final value of original.
        /// </summary>
        public _02154_KeepMultiplyingFoundValuesByTwo()
        {
            Console.WriteLine(FindFinalValue([5, 3, 6, 1, 12], 3));
            Console.WriteLine(FindFinalValue([2, 7, 9], 4));
        }

        private static int FindFinalValue(int[] nums, int original)
        {
            while (nums.Contains(original))
            {
                original *= 2;
            }

            return original;
        }
    }
}
