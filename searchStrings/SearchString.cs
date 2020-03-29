using System;
using System.Collections.Generic;
using System.Linq;

namespace searchStrings
{
    class SearchStrings
    {
        IEnumerable<string>  keywords = null;
        public void AddStrings(IEnumerable<string> words)
        {
            keywords = from s in words
                       orderby s
                       select s;
        }

        public IEnumerable<string> GetSuggestions(string str)
        {
            if(str.Length < 3) return new string[0];
            var matches = from s in keywords
                          where s.StartsWith(str)
                          select s;
            return matches.Take(3);
        }
    }
}