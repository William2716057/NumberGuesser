using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace NumberGuesser
{
    //main class
    internal class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //string name = "User";
            //int age = 20;
            //Console.WriteLine(name + " is " + age);
            //Console.WriteLine("{0 is {1}", name, age);
            string appName = "Number Guessr";
            string appVersion = "1.0.0";
            string appAuthor = "Person";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();

        }
    }
}
