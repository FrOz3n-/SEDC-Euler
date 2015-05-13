using EulerEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions.SWeko
{
    class Problem005 : IProblemSolution
    {
        public int ProblemID
        {
            get { return 5; }
        }

        public long Execute()
        {
            var result = SmallestEvenlyDivisible();
            return result;
        }

        public long SmallestEvenlyDivisible()
        {
            long n=19;
            while(true)
            {
                bool isDivisible = true;
                for (int i = 1; i <= 20; i++)
                {
                    if(n%i != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                    return n;
                n+=19;
            }
        }
    }
}
