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

            //Enter name here
            Console.WriteLine("Enter Name Here: ");
            //enter as string
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play", inputName);

            //initialise number 
            int correctNumber = 7;


            //initialise guess 
            int guess = 0;

            //ask for input
            Console.WriteLine("Enter number between 1 and 10");
            //loop so if not correct ask again
            while (guess != correctNumber)
            {
                //Get input
                string input = Console.ReadLine();

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //match guess to correct number
                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong Number, try again");

                    //Console.ForegroundColor = ConsoleColor.Green;
                    Console.ResetColor();
                }
            }

            //output success message
            Console.ForegroundColor = ConsoleColor.Yellow;
            //right number message 
            Console.WriteLine("You are correct");

            //Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();
        }
    }
}
