using System;

namespace TrieData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Trie tr = new Trie();
            tr.Addword("abc");
            if(tr.Exist("abc"))
            {
                Console.WriteLine("Found!");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}
