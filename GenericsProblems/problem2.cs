using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class problem2
    {
        public static void usingGenerics<T>(T[] Inputarray, T element)
        {
            T[] temparray = new T[Inputarray.Length - 1];
            int flag = 0;
            for (int i = 0; i < Inputarray.Length; i++)
            {
                if (!Inputarray[i].Equals(element))
                {
                    temparray[flag] = Inputarray[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);
        }
    }
}
