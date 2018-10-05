using System.Collections.Generic;
namespace TrieData
{
    public class TrieNode
    {
        bool isWord;
        Dictionary<char, TrieNode> children;

        public bool IsWord => isWord;
        public TrieNode()
        {
            isWord = false;
            children = new Dictionary<char, TrieNode>();
        }

        public TrieNode(char c, bool isLast = false)
        {
            isWord = isLast;
            children = new Dictionary<char, TrieNode>();
        }

        // Will Throw exception is c already exist as child.
        public void AddChild(char c, TrieNode tn)
        {
            children[c] = tn;
        }
        public TrieNode GetHoldingNode(char c)
        {
            if(!children.ContainsKey(c))
            {
                return this;
            }
            return children[c].GetHoldingNode(c);
        }

        public bool Seek(char c, out TrieNode n)
        {
            n = null;
            if(!children.ContainsKey(c))
            {
                return false;
            }
            n = children[c];
            return true;
        }

    }
}