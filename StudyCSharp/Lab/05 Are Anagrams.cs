using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Lab
{
    internal class _05_Are_Anagrams
    {
        bool AreAnagrams(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) { return false; }

            // Dictionary to count how often each letter appears
            Dictionary<char, int> dict = new Dictionary<char, int>();

            // Using an array makes it easy to iterate over the characters
            char[] charArr = a.ToLower().ToCharArray();

            // Count each character from the first string, ignore whitespace
            foreach (var item in charArr)
                if (char.IsWhiteSpace(item))
                    continue;
                else if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);

            // Remove first string from array and put second one in it
            charArr = b.ToLower().ToCharArray();

            // Decrease the count for each character in the second string
            // If a character is missing or the count goes below 0, it's not an anagram
            foreach (var item in charArr)
                if (char.IsWhiteSpace(item))
                    continue;
                else if (dict.ContainsKey(item))
                {
                    dict[item]--;
                    if (dict[item] < 0) { return false; }
                }
                else
                    return false;

            // If all counts end up at 0, both strings contain the same characters
            return dict.Values.All(x => x == 0) ? true : false;
        }
    }
}
