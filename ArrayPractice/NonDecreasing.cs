/*
Given an array with n integers, your task is to check if it could become
non-decreasing by modifying at most 1 element.
We define an array is non-decreasing if 
array[i] <= array[i + 1] holds for every i (1 <= i < n).

Example 1:
Input: [4,2,3]
Output: True
Explanation: You could modify the first 4 to 1 to get a non-decreasing array.
Example 2:
Input: [4,2,1]
Output: False
Explanation: You can't get a non-decreasing array by modify at most one element.
 */

namespace ArrayPractice
{
    using System;
    using TestSupport;
public class NonDecreasing {
    public bool CheckPossibility(int[] nums)
    {
        if(nums.Length < 3)
        {
            return true;
        }
        int maxSoFar = Int32.MinValue;
        for (int i=1; i < nums.Length; ++i)
        {
            if (nums[i-1] > nums[i])
            {
                        // option 1: decrease i-1
                return (  testNoDecreasing(nums, Math.Max(nums[i], maxSoFar), i)
                        // option 1: increase i
                       || testNoDecreasing(nums, nums[i-1], i+1));
            }
            maxSoFar = nums[i-1];
        }
        return true;
    }
    
    private bool testNoDecreasing(int[] nums, int prev, int idx)
    {
        for (int i = idx; i < nums.Length; ++i)
        {
            if(prev > nums[i])
            {
                return false;
            }
            prev = nums[i];
        }
        return true;
    }

    public void Test()
    {
        int[] input1 = {3, 4, 2, 3};
        Assert.IsTrue(!CheckPossibility(input1), "NonDecreasing Test 1", "Expected false");

        int[] input2 = {4, 2, 3};
        Assert.IsTrue(CheckPossibility(input2), "NonDecreasing Test 2", "Expected true");
    }
}
}