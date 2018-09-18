using System;

namespace MaxSumSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution obj = new Solution();
            int[] input = {-1,4,-6,1,1,1,2,-1,-1};
            Console.WriteLine("Max Sum: {0}", obj.maxSubArray(input));
            int[] input2 = { -1, -4, -6, -1, -1, -1, -2, -1, -1 };
            Console.WriteLine("Max Sum: {0}", obj.maxSubArray(input2));
        }
    }
}
