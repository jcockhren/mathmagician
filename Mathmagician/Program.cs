using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Terminal term = new Terminal();

            Console.WriteLine(term.AskFirstQuestion());
            string class_type = Console.ReadLine();
            string first_ans = term.AcceptFirstAnswer(class_type);
            Console.WriteLine(first_ans);
            if (term.Progress == 0)
            {
                return;
            } 
            string how_many = Console.ReadLine();
            string second_ans = term.AcceptSecondAnswer(how_many);
            Console.WriteLine(second_ans);
            if (term.Progress == 1)
            {
                return;
            }
            string final_ans = term.PrintSequence();
            Console.WriteLine(final_ans);
            Console.ReadKey();
        }
    }
}
