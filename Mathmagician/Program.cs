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
            string prompt = "> ";
            Console.WriteLine("What do you want me to do?");
            Console.Write(prompt);
            string response = Console.ReadLine();
            if (response == "natural numbers")
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    NaturalNumbers nats = new NaturalNumbers();
                    Console.WriteLine(nats.ToString(nats.GetSequence(length)));
                } else
                {
                    Console.WriteLine("Whoops!");
                }
                
            }
            else {
                Console.WriteLine("Nope! Do better next time.");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
