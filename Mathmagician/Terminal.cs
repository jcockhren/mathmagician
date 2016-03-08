using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Terminal
    {
        string[] steps = {
            "What would you like for me to do?",
            "How many should I print?",
            "ACK", // Maybe use later?
            "Ans"
        };

        string[] classes =
        {
            "Even",
            "Odd",
            "Integer",
            "Fibonacci",
            "Prime"
        };

        public int Progress { get; private set; }
        public int Count { get; private set; }
        public string NumberFamily { get; private set; }

        public Terminal()
        {
            Progress = -1;
        }

        public string AskFirstQuestion()
        {
            return steps[0];
        }

        public string PrintHelp()
        {
            throw new NotImplementedException();
        }

        public string AcceptFirstAnswer(string user_input)
        {
            if (Progress != 0)
            {
                Progress = 0;
            }

            foreach (var item in classes)
            {
                if (String.Equals(user_input.ToLower(), item.ToLower()))
                {
                    Progress++;
                    NumberFamily = user_input.ToLower();
                    break;
                }
            }

            if(NumberFamily == null)
            {
                return "Whoops!";
            }
            // Should create new instance or something
            return steps[Progress];

            // Requires knowing the classes we have available
            // Think about user input variations: Capitalization

            // Know how to call the class. 
        }

        public string AcceptSecondAnswer(string user_input)
        {
            int output;
            if (Progress != 1)
            {
                Progress = 1;
            }
            bool success = int.TryParse(user_input, out output);
            if (success)
            {
                
                Progress++;
                Count = output;
                return String.Format("Cool. I'm going to print {0} {1} numbers", Count, NumberFamily);
            } else
            {
                return "Whoops!";
            }
        }

        public Integer NumberFamilyFactory()
        {
            if (NumberFamily == "prime")
            {
                return new Prime();
            } else if (NumberFamily == "fibonacci")
            {
                return new Fibonacci();

            }
            else if (NumberFamily == "odd")
            {
                return new Odd();
            }
            else if (NumberFamily == "integer")
            {
                return new Integer();

            }
            else if (NumberFamily == "even")
            {
                return new Even();
            }
            else
            {
                return null;
            }
        }

        public string PrintSequence()
        {
            try
            {
                int[] seq = NumberFamilyFactory().GetSequence(Count);
                return String.Join(" ", seq);
            }
            catch (Exception)
            {
                return "Whoops!";
            }
        }
        /*
private static bool findClass(String input)
{


}
*/
    }
}
