using EulerEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions.SWeko
{
    class Problem004 : IProblemSolution
    {
        public int ProblemID
        {
            get { return 4; }
        }

        public long Execute()
        {
            var result = LargestPalindrome();
            return result.Max();
        }

        static List<long> LargestPalindrome()
        {
            long product = 0;
            long compare = 0;
            List<long> results = new List<long>();
            for (uint i = 100; i < 1000; i++)
            {
                for (uint j = 100; j < 1000; j++)
                {
                    product = i * j;
                    StringBuilder value = new StringBuilder(product.ToString());

                    //Pass string to reverse
                    string value_r = value.ToString();
                    value = new StringBuilder(new string(value_r.Reverse().ToArray()));

                    //Check if Numeric Palindrome
                    if (value_r.Equals(value.ToString()) && product > compare)
                    {
                        results.Add(product);
                    }
                }
            }

            results.Sort();
            return results;
        }
    }
}
