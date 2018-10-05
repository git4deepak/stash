using System.Collections.Generic;
namespace TrieData
{
    public class Trie
    {
        TrieNode root = null;

        public Trie()
        {
            root = new TrieNode();
        }
        public void Addword(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return;
            }

            TrieNode node, searchHere = root;
            int i=0;
            for (; i < word.Length-1; ++i)
            {
                node = searchHere.GetHoldingNode(word[i]);
                node.AddChild(word[i], new TrieNode(word[i]));
                searchHere = node;
            }
            node = searchHere.GetHoldingNode(word[i]);
            node.AddChild(word[i], new TrieNode(word[i], true/*IsLast*/));
        }

        public bool Exist(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            TrieNode node, searchHere;
            node = searchHere = root;
            int i=0;
            bool found = false;
            for (; i < word.Length; ++i)
            {
                found = searchHere.Seek(word[i], out node);
                if(!found)
                {
                    return false;
                }
                searchHere = node;
            }
            return (found && node.IsWord);
        }


    }
}