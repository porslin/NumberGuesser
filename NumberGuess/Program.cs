// main class
using System.Net.NetworkInformation;

class Program
{
    // entry point method. method is a function inside of a class
    static void Main(string[] args)
    {
        // defining variables
        // string name = "Jacob Westman";
        // int age = 38;

        // start here
        // Console.WriteLine("Hi "+name+"! You are "+age+"years old.");
        // Console.WriteLine("Hi {0}, you are {1}.",name,age);

        // run get app info fn 
        GetAppInfo();

        // run greet user fn
        GreetUser();

        while (true)
        {

            // define correct number
            // int correctNumber = 9;

            // create a new Random object (inbuilt var)
            Random random = new Random();

            // intialize correct number using random fn 
            int correctNumber = random.Next(1, 11);

            // define guess variable
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            // while guess is not correct 
            while (guess != correctNumber)
            {
                // keep asking for users input
                string input = Console.ReadLine();

                // ensuring the input is a number
                if (!int.TryParse(input, out guess))
                {
                    // run error message in diffrnt color with given parameters
                    PrintColorMessage(ConsoleColor.Red, "Please enter an actual number!");

                    // let program keep running 
                    continue;
                }

                // cast input value to int and put in guess var
                guess = Int32.Parse(input);

                // match guess to correct number 
                if (guess != correctNumber)
                {
                    // run error message here in another color
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, guess again!");
                }
            }

            // output success message 
            // print success message with given parameters on color message fn 
            PrintColorMessage(ConsoleColor.Yellow, "Yay, you got it!");

            // ask user to play again 
            Console.WriteLine("Play again? [Y or N]");

            // get user choice 
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                continue;
            }
            else if (answer == "N")
            {
                return;
            }

        }
    }

    static void GetAppInfo()
    {
        // defining app info variables 
        string appName = "Number Guesser";
        string appVersion = "1.0.1";
        string appAuthor = "Porslin H";

        // change text color
        Console.ForegroundColor = ConsoleColor.Green;

        // print appinfo in console
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

        // reset text color 
        Console.ResetColor();
    }

    static void GreetUser()
    {

        // ask users name
        Console.WriteLine("What is your name?");

        // get and define user input 
        string inputName = Console.ReadLine();

        Console.WriteLine("Hello {0}, let's play a game!", inputName);
    }

    static void PrintColorMessage(ConsoleColor color, string message)
    {
        // change text color
        Console.ForegroundColor = color;

        // tell user its the wrong number
        Console.WriteLine(message);

        // reset text color 
        Console.ResetColor();
    }
}

