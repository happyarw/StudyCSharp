using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Lab
{
    internal class _02_Find_Max_Number
    {
        public int FindMaxNumber(int[] numbers)
        {
            if (numbers is not { Length: > 0 })
                return 0;

            int result = 0;

            foreach (var n in numbers)
                if (n > result)
                    result = n;

            return result;
        }
    }
}
