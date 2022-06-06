using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juniorHomework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string program = "17.2.3";
            string programVersion = "Visual Studio";
            string temporaryVariable;

            Console.WriteLine("Перед заменой: {0} {1}", program, programVersion);
            temporaryVariable = program;
            program = programVersion;
            programVersion = temporaryVariable;
            Console.WriteLine("После замены: {0} {1}", program, programVersion);
        }
    }
}
