using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class OddNumbers : NaturalNumbers
    {
        public OddNumbers() /*: base()*/
        {
            // maybe forcing the call to the Parent Constructor
            increment = 2;
            first = 1;
        }
    }
}
