
using System;

namespace AlgorithmsPractice.LeetCode
{
    public class SearchInsertPositionClass
    {
        public static int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }
        
        private static int BinarySearch(int[] nums, int start, int end, int target)
        {
            int midIndex = (start + end) / 2;
            int mid = nums[midIndex];

            if (mid == target)
                return midIndex;

            if (start == end)
                return start + 1;

            if (target < mid)
                return BinarySearch(nums, start, midIndex, target);
            else
                return BinarySearch(nums, midIndex + 1, end, target);
        }
    }
}
