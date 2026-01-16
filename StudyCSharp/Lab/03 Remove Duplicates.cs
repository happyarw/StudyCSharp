using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Lab
{
    internal class _03_Remove_Duplicates
    {
        int[] RemoveDuplicates(int[] numbers) 
        { 
            if (numbers is not { Length: > 0 }) 
                return numbers; 
            
            HashSet<int> set = new HashSet<int>(); 
            List<int> list = new List<int>(); 
            
            foreach (var n in numbers)
                // The exclamation mark (!) negates the condition.
                // In plain English: if the set does NOT contain this number yet.
                if (!set.Contains(n))
                {
                    // Mark this number as seen so duplicates are skipped next time.
                    set.Add(n);
                    // Add the number to the result list.
                    // We use a List because HashSet does not guarantee order.
                    list.Add(n); 
                } 

            return list.ToArray(); 
        }
    }
}
