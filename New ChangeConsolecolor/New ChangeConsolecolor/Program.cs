using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_ChangeConsolecolor
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("I heloo word");
            Console.WriteLine("wassup dude");
            Console.WriteLine("wassup dude1");
            Console.Read();
            
        }
    }
}
