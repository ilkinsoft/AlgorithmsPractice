using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Strings_Arrays
{
    public class LeetCode
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], 9 - nums[i]);
            }
            for (int i = 0; i < dic.Count; i++)
            {
                int val = dic[i];
                if (dic.ContainsKey(val))
                {
                    result[0] = i;
                    //result[1] = nums.indexof(val);
                    break;
                }
            }
            return result;
        }

    }
}
