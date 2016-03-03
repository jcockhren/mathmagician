using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Terminal
    {
        string[] steps = { "Q1", "Q2", "ACK", "Ans" };

        public int Progress { get; private set; }

        public Terminal()
        {
            Progress = -1;
        }

        public string AskFirstQuestion()
        {
            return "What would you like for me to do?";
        }

        public string PrintHelp()
        {
            throw new NotImplementedException();
        }

        public string AcceptFirstAnswer(string user_input)
        {
            throw new NotImplementedException();
        }
    }
}
