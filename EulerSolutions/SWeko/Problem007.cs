using EulerEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions.SWeko
{
    class Problem007 : IProblemSolution
    {
        public int ProblemID
        {
            get { return 7; }
        }

        public long Execute()
        {
            var result = GeneratePrimesNaive(10001);
            return result.Last();
        }

        public static List<long> GeneratePrimesNaive(long n)
        {
            List<long> primes = new List<long>();
            primes.Add(2);
            long nextPrime = 3;
            while (primes.Count < n)
            {
                long sqrt = (long)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
    }
}
