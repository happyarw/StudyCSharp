using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Lab
{
    internal class _04_Most_Frequent_Number
    {
        int MostFrequentNumber(int[] numbers) 
        { 
            if (numbers is not { Length: > 0 }) 
                return 0;

            // Dictionary to count how often each number appears.
            // Dictionary<key, value>
            // key   = the number itself.
            // value = how many times it occurs in the array.
            Dictionary<int, int> dict = new Dictionary<int, int>(); 
            
            foreach (int number in numbers) 
                if (dict.ContainsKey(number))
                {
                    // Number already seen, increase by one.
                    dict[number]++;
                }
                else
                {
                    // First time we see this number, start counter at one.
                    dict.Add(number, 1);
                }

            // MaxBy selects the dictionary entry with the highest value.
            // kvp represents a KeyValuePair, aka a dictionary entry.
            // kvp => kvp.Value tells MaxBy to compare entries by their Value
            int maxCount = dict.MaxBy(kvp => kvp.Value).Value;

            // Iterate over the original array again to return the first number that reaches this max count
            foreach (int number in numbers) 
                if (dict[number] == maxCount) 
                    return number; 
            
            return 0; 
        }
    }
}
