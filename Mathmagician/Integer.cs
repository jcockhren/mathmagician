using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {

        public int Max { get; private set; }
        protected int Step { get; set; }
        protected int First { get; set; }

        /*
        Using properties is like:
        private int MAX = 50;
        public int GetMax() {
            return this.MAX
        }

        private void SetMax(int new_max) {
            this.MAX = new_max;
        }
         */

        public Integer()
        {
            Max = 50;
            Step = 1;
            First = 0;
        }

        virtual public int GetFirst()
        {
            return First;
        }

        virtual public int GetNext(int current)
        {
            return current + Step;
        }

        public int[] GetSequence(int how_many)
        {
            if (how_many > Max)
            {
                throw new Exception();
            }
            int[] seq_array = new int[how_many];
            /*
            for (int i = 0; i < how_many; i++)
            {
                seq_array[i] = i;
            }*/
            int counter = 0;
            seq_array[counter] = GetFirst();
            while (counter < how_many -1)
            {
                /* Attempt 1
                seq_array[counter+1] = GetNext(seq_array[counter]);
                counter++;
                */
                counter++;
                seq_array[counter] = GetNext(seq_array[counter-1]);
            }

            return seq_array;
        }
    }
}
