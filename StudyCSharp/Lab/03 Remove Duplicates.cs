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
            
            foreach (var item in numbers) 
                if (!set.Contains(item))
                { 
                    set.Add(item); 
                    list.Add(item); 
                } 

            return list.ToArray(); 
        }
    }
}
