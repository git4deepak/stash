namespace TestSupport
{
    using System;
    public class Assert
    {
        public static void IsTrue(bool condition, string testName, string context)
        {
            if(!condition)
            {
                Console.WriteLine($"{testName} : failed. {context}");
            }
            else
            {
                Console.WriteLine($"{testName} : passed.");
            }
        }
    }
}