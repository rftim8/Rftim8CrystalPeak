namespace Rftim8LeetCode.Temp
{
    public class _00080_RemoveDuplicatesFromSortedArrayII
    {
        /// <summary>
        /// Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice. 
        /// The relative order of the elements should be kept the same.
        /// Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.
        /// More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result.
        /// It does not matter what you leave beyond the first k elements.
        /// Return k after placing the final result in the first k slots of nums.
        /// Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
        /// Custom Judge:
        /// The judge will test your solution with the following code:
        /// int[] nums = [...]; // Input array
        /// int[] expectedNums = [...]; // The expected answer with correct length
        /// int k = removeDuplicates(nums); // Calls your implementation
        /// assert k == expectedNums.length;
        /// for (int i = 0; i<k; i++) {
        ///     assert nums[i] == expectedNums[i];
        /// }
        /// If all assertions pass, then your solution will be accepted.
        /// </summary>
        public _00080_RemoveDuplicatesFromSortedArrayII()
        {
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII0([1, 1, 1, 2, 2, 3]));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII0([0, 0, 1, 1, 1, 1, 2, 3, 3]));
        }

        public static int RemoveDuplicatesFromSortedArrayII0(int[] a0) => RftRemoveDuplicatesFromSortedArrayII0(a0);

        private static int RftRemoveDuplicatesFromSortedArrayII0(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= 1 || nums[i] > nums[j - 2])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}
