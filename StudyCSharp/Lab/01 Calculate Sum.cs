using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Lab
{
    internal class _01_Calculate_Sum
    {
        public int Sum(int[] numbers)
        {
            // If the array is NULL or empty, return
            if (numbers is not { Length: > 0 })
                return 0;

            int result = 0;

            // Foreach number (n) in the array, add it to the result
            foreach (var n in numbers)
                result += n;

            return result;
        }
    }
}
