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
            
            Dictionary<int, int> dict = new Dictionary<int, int>(); 
            
            foreach (int number in numbers) 
                if (dict.ContainsKey(number)) 
                    dict[number]++; 
                else 
                    dict.Add(number, 1); 
            
            int maxCount = dict.MaxBy(kvp => kvp.Value).Value; 
            
            foreach (int number in numbers) 
                if (dict[number] == maxCount) 
                    return number; 
            
            return 0; 
        }
    }
}
