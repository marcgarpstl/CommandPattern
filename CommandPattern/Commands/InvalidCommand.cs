using CommandPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class InvalidCommand : Icommand
    {
        public void Execute()
        {
            Console.WriteLine("Dog doesn't know this command.");
        }
    }
}
