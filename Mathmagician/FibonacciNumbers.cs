using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            increment = 0;
            first = 1;
        }

        public override int GetNext(int x)
        {
            int storage = increment;
            increment = x;
            return x + storage;
        }
    }
}
