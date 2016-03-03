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

            for (int i = 2; i < p-1; i++)
            {
                if(p % i == 0) {
                    return false;
                }
            }

            return true;
        }


    }
}
