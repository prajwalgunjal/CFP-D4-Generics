using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class Problem4
    {
        public void FindMaxNumber(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine($"Largest number is :- {max}");
        }
    }
}
