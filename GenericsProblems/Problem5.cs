﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class Problem5
    {

        public void FindMinNumber(float num1, float num2, float num3)
        {
            float min = num1;

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"Smallest number is :- {min}");
        }
    }
}
