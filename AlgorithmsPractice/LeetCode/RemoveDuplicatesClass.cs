using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LeetCode
{
    public class RemoveDuplicatesClass
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // 1, 2, 4, 4, 5, 7

            int removed = 0;

            for (int i = 0; i < nums.Length - removed - 1; i++)
            {

                if (nums[i] == nums[i + 1])
                {
                    nums = RemoveOne(nums, i + 1);
                    removed++;
                }
            }
            Console.WriteLine(nums.Length - removed);

            return nums.Length - removed;
        }

        private static int[] RemoveOne(int[] nums, int dupIndex)
        {
            for (int i = dupIndex; i < nums.Length - 1; i++)
                nums[i] = nums[i + 1];

            return nums;
        }
    }
}
