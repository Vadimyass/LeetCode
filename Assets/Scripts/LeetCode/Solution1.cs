using UnityEngine;

namespace LeetCode
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = nums.Length - i - 1; j >= 0; j--)
                {
                    if(nums[i] + nums[j] == target && nums[i] != nums[j])
                    {
                        result[0] = nums[i];
                        result[1] = nums[j];
                        Debug.LogError(nums[i] + " " + nums[j] + "succesfully found");
                        return result;
                    }
                }
            }

            return null;
        }
    }
}