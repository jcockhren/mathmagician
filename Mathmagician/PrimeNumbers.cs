using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        private int[] list_of_primes;
        private int upper_bound;
        public PrimeNumbers()
        {
            list_of_primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};
            first = 2;
            upper_bound = 200;
        }

        public bool IsPrime(int x)
        {
            bool result = false;
            bool found_composite = false;
            int i = 3;
            while ( i < x)
            {
                if (x % i == 0)
                {
                  found_composite = true;
                  break;
                }
                i += 2;
            }
            if (!found_composite) {
                result = true;
            }

            return result;
        }

        public override int GetNext(int x)
        {
            if (x < 100)
            {
                return list_of_primes[FindIndex(x) + 1];
            } else if (x > upper_bound)
            {
                throw new ArgumentException("Sowwy. You've exceeded our capabilities.");
            } else if (!IsPrime(x))
            {
                throw new ArgumentException();
            }
            else
            {
                int candidate = x+2;
                while (!IsPrime(candidate)) {
                    candidate += 2;
                }
                return candidate;

            }
            
        }

        public int FindIndex(int element) {
            
            if (list_of_primes.Contains(element))
            {
                for (int i = 0; i < list_of_primes.Length; i++)
                {
                    if (list_of_primes[i]== element) {
                        return i;
                    }
                }
                throw new ArgumentException();
            } else
            {
                throw new ArgumentException();
            }
        }

    }
}
