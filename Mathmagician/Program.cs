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
            // Arrange
            Terminal term = new Terminal();

            // Act
            Console.WriteLine(term.AskFirstQuestion());
            string class_type = Console.ReadLine();
            string first_ans = term.AcceptFirstAnswer(class_type);
            if (term.Progress == 0)
            {
                Console.WriteLine(first_ans);
                return;
            } else
            {
                Console.WriteLine(first_ans);
            }
            string how_many = Console.ReadLine();
            string second_ans = term.AcceptSecondAnswer(how_many);
            if (term.Progress == 1)
            {
                Console.WriteLine(second_ans);
                return;
            }
            string final_ans = term.PrintSequence();
            Console.WriteLine(final_ans);
            Console.ReadKey();
        }
    }
}
