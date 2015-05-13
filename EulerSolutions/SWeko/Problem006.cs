using EulerEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions.SWeko
{
    class Problem006 : IProblemSolution
    {
        public int ProblemID
        {
            get { return 6; }
        }

        public long Execute()
        {
            var result = First100Difference();
            return result;
        }

        public long First100Difference()
        {
            //         n*(2n + 1)*(n+1)
            //f(n) = -------------------
            //                6
            long sumSquares = (100 * 201 * 101) / 6;

            long sumFirstN = (100 * 101) / 2;

            sumFirstN *= sumFirstN;

            return Math.Abs(sumSquares - sumFirstN);
        }
    }
}
