using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : Integer
    {
        private int[] elements;
        public Fibonacci()
        {
            First = 1;
            elements = new int[Max];

            elements[0] = 1;
            elements[1] = 1;
            elements[2] = 2;
            elements[3] = 3;
            elements[4] = 5;

            for (int n = 6; n < Max; n++)
            {
                elements[n - 1] = GetNthCached(n);
            }
        }

        public override int GetNext(int current)
        {
            int actual_index = Array.FindIndex(elements, value => 8 == value);

            return elements[actual_index+1];
        }

        public int GetNth(int n)
        {
            if (n <= 0) { throw new Exception(); }

            if (n == 1 || n == 2)
            {
                return 1;
            } else
            {
                return GetNth(n-1) + GetNth(n-2);
            }
        }

        public int GetNthCached(int n)
        {
            if (n <= 0) { throw new Exception(); }

            if (elements[n-1] != 0)
            {
                return elements[n-1];
            } else
            {

                int first_term;
                if (elements[n-2] == 0)
                {
                    first_term = GetNthCached(n - 1);
                    elements[n - 2] = first_term;
                } else
                {
                    first_term = elements[n-2];
                }

                int second_term;
                if (elements[n - 3] == 0)
                {
                    second_term = GetNthCached(n - 2);
                    elements[n - 3] = first_term;
                }
                else
                {
                    second_term = elements[n - 3];
                }
                return first_term + second_term;
            }
        }

        override public int[] GetSequence(int how_many)
        {
            if (how_many > Max)
            {
                throw new Exception();
            }
            int[] seq_array = new int[how_many];
            /*
            int counter = 0;
            seq_array[counter] = GetFirst();
            while (counter < how_many - 1)
            {
                counter++;
                seq_array[counter] = GetNext(seq_array[counter - 1]);
            }
            */

            for (int n = 0; n < how_many; n++)
            {
                seq_array[n] = GetNth(n + 1);
            }


            return seq_array;
        }
    }
}
