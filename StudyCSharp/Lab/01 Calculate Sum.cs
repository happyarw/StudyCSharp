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
            if (numbers is not { Length: > 0 })
                return 0;

            int result = 0;

            foreach (var number in numbers)
                result += number;

            return result;
        }
    }
}
