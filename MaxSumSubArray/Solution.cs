using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSumSubArray
{
    class Solution
    {
        public int maxSubArray(int[] nums)
        {

            int max_curr, max_global;
            max_curr = max_global = nums[0];
            int start, end, gStart, gEnd;
            start = end = gStart = gEnd = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i] + max_curr)
                {
                    max_curr = nums[i];
                    start = end = i;
                }
                else
                {
                    max_curr = nums[i] + max_curr;
                    end = i;
                }

                //max_curr = Math.Max(nums[i], nums[i] + max_curr);

                if (max_global < max_curr)
                {
                    max_global = max_curr;
                    gStart = start;
                    gEnd = end;
                }
            }
            Console.WriteLine("Range [{0}, {1}]", gStart, gEnd);
            return max_global;
        }
    };
}
