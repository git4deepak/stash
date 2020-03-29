using System;

namespace searchStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SerchStrings");
            var obj = new SearchStrings();
            string[] input1 = {"Aman", "Deep", "Dev", "Dee", "Deepal", "Deepak", "Rakesh"};
            obj.AddStrings(input1);
            var sss = new string[]{"Dee", "Deep", "Deepak", "Ama", "nothing"};
            foreach(var ss in sss)
            {
                var result1 = obj.GetSuggestions(ss);
                Console.WriteLine($"{ss} : {String.Join(',', result1)}");
            }
        }
    }
}
