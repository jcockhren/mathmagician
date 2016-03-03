using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Prime : Integer
    {
        public Prime()
        {
            First = 2;
        }

        public bool IsPrime(int p)
        {
            if (p > 2 && p%2 == 0)
            {
                return false;
            }
            /*
            for (int i = 2; i < p-1; i++)
            {
                if(p % i == 0) {
                    return false;
                }
            }*/
            int i = 2;
            while (i < (p-1)/2)
            {
                if (p % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }


        public override int GetNext(int current)
        {
            int candidate = current+1;
            while (!IsPrime(candidate))
            {
                candidate++;
            }
            return candidate;
        }

    }
}
