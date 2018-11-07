using System;

namespace TrieData
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie tr = new Trie();
            tr.Addword("abc");
            tr.Addword("abcdef");
            tr.Addword("doctor");
            tr.Addword("apple");
            tr.Addword("applepie");
            Test(tr.Exist("apple") == true, "Existing Word Lookup");
            Test(tr.Exist("doctor") == true, "Existing Word Lookup2");
            Test(tr.Exist("applepie") == true, "Existing Word Lookup3");
            Test(tr.Exist("applew") == false, "Non Existing Word Lookup");
            Test(tr.Exist("zyx") == false, "Non Existing Word Lookup2");
        }

        static void Test(bool test, string context)
        {
            string result = test ? "Passed" : "Failed";
            Console.WriteLine("{0}: {1}", result, context);
        }
    }
}
