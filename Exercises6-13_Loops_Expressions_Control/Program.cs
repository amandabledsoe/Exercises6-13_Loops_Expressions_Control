using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises6_13_Loops_Expressions_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;
            string userInput;
            bool isANumber;

            Console.WriteLine("Welcome to the program for Exercises 6 - 13 in the 2022 Grand Circus C# .Net boot camp.");
            Console.WriteLine("");
            while (runningProgram)
            {
                Console.WriteLine("Which exercise would you like to run?");
                Console.Write("Enter a number between 6 and 13 inclusive: ");
                userInput = Console.ReadLine();
                isANumber = int.TryParse(userInput, out int exerciseNumber);
                if (isANumber)
                {
                    if (exerciseNumber >= 6 && exerciseNumber <= 13)
                    {
                        Console.WriteLine("");
                        switch (exerciseNumber)
                        {
                            case 6:
                                Console.Clear();
                                DoExercise6();
                                break;
                            case 7:
                                Console.Clear();
                                DoExercise7();
                                break;
                            case 8:
                                Console.Clear();
                                DoExercise8();
                                break;
                            case 9:
                                Console.Clear();
                                // Prompt the user to enter a language. Based on the language the user input, display "Hello, World!" in that language.
                                // Use a switch statement to choose what to display.
                                break;
                            case 10:
                                Console.Clear();
                                // Determine whether the user is tall enough to ride a roller coaster. Prompt the user to enter her height in inches.
                                // If she is less than 54 inches tall, notify her that she cannot ride the Raptor. If she is at least 54 inches tall, notify her that she can ride the Raptor.
                                break;
                            case 11:
                                Console.Clear();
                                // Use a for loop to output all the numbers from 0 to 9.
                                break;
                            case 12:
                                Console.Clear();
                                // Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.
                                break;
                            case 13:
                                Console.Clear();
                                // call a methodPrompt the user for a number. Use a for loop to output all the numbers from that number to 0.
                                break;
                        }
                        runningProgram = RunProgramAgainPrompt();
                    }
                    else if (exerciseNumber < 6 || exerciseNumber > 13)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that number appears to be out of range. Please try again.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that doesnt appear to be a number. Please try again.");
                    Console.WriteLine("");
                    runningProgram = true;
                }
            }
            Console.WriteLine("This concludes Exercises 6 - 13 for the 2022 Grand Circus C# .Net boot camp.");
            Console.WriteLine("Goodbye...");
        }
        static bool RunProgramAgainPrompt()
        {
            bool promptingUser = true;
            while (promptingUser)
            {
                Console.WriteLine("Would you like to do another exercise?");
                Console.WriteLine("Enter 'y' or 'yes' to do another exercise, or enter 'n' or 'no' to exit the program.");
                string userInput = Console.ReadLine().ToLower();
                if(userInput == "y" || userInput == "yes")
                {
                    Console.WriteLine("");
                    Console.Clear();
                    promptingUser = false;
                    return true;
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("");
                    Console.Clear();
                    promptingUser = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, I didn't understand that response. Please try again.");
                    Console.WriteLine("");
                    promptingUser = true;
                }
            }
            return false;
        }
        static void DoExercise1()
        {
            Console.Write("Hello User! Please enter any phrase and I will repeat it back to you: ");
            Console.WriteLine("");
            string userInput = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Your phrase was: ");
            Console.WriteLine(userInput);
            Console.WriteLine("");
        }
        static void DoExercise2()
        {
            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.");
            Console.WriteLine("");

            bool doingExercise2 = true;
            while (doingExercise2)
            {
                Console.Write("Please enter a number and I will output your number +1: ");
                string userInput = Console.ReadLine();
                bool isANumber = int.TryParse(userInput, out int userInteger);
                if (isANumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Your number +1 is: {userInteger + 1}");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to Continue.");
                    Console.ReadLine();
                    Console.Clear();
                    doingExercise2 = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't add one.");
                    Console.WriteLine("Press enter and let's try again");
                    Console.ReadLine();
                    doingExercise2 = true;
                }
            }
        }
        static void DoExercise3()
        {
            Console.WriteLine("EXERCISE 3:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.");
            Console.WriteLine("");

            //NEED TO A LOOP TO RETRY IF NOT A NUMBER HERE
            bool doingExercise3 = true;
            while (doingExercise3)
            {
                Console.Write("Please enter a number and I will output your number +0.5: ");
                string userInput = Console.ReadLine();
                bool isANumber = double.TryParse(userInput, out double userDouble);
                if (isANumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Your number +0.5 is: {userDouble + .5}");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to Continue.");
                    Console.ReadLine();
                    Console.Clear();
                    doingExercise3 = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't add one.");
                    Console.WriteLine("Press enter and let's try again");
                    Console.ReadLine();
                    doingExercise3 = true;
                }
            }
        }
        static void DoExercise4()
        {
            Console.WriteLine("EXERCISE 4:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter two numbers. " +
                "After the user enters the numbers, add them together and output the sum back to the console.");
            Console.WriteLine("");

            List<double> numbers4 = new List<double>();
            bool doingExercise4 = true;
            while (doingExercise4)
            {
                for (int i = 1; i < 3; i++)
                {
                    if (numbers4.Count < 1)
                    {
                        Console.Write("Enter your first number: ");
                        string userInput = Console.ReadLine();
                        Console.WriteLine("");
                        bool isANumber = double.TryParse(userInput, out double userDouble);
                        if (isANumber)
                        {
                            numbers4.Add(userDouble);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                            Console.WriteLine("Press enter and let's try again");
                            Console.ReadLine();
                            i = 0;
                            doingExercise4 = false;
                        }
                    }
                    else if (numbers4.Count <= 1)
                    {
                        Console.Write("Enter your second number: ");
                        string userInput = Console.ReadLine();
                        Console.WriteLine("");
                        bool isANumber = double.TryParse(userInput, out double userDouble);
                        if (isANumber)
                        {
                            numbers4.Add(userDouble);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                            Console.WriteLine("Press enter and let's try again");
                            Console.ReadLine();
                            if (numbers4.Count == 1)
                            {
                                i = 1;
                                doingExercise4 = true;
                            }
                            else
                            {
                                doingExercise4 = false;
                            }
                        }
                    }

                }
                if (numbers4.Count <= 1)
                {

                }
                else if (numbers4.Count == 2)
                {
                    int total = numbers4.Sum(x => Convert.ToInt32(x));
                    Console.WriteLine($"The sum of your two numbers is: {total}");
                }
                doingExercise4 = false;
            }
            Console.WriteLine("");

            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise5()
        {
            Console.WriteLine("EXERCISE 5:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter two numbers. " +
                "After the user enters the numbers, multiply them and output the product back to the console.");
            Console.WriteLine("");

            bool doingExercise5 = true;
            List<double> numbers5 = new List<double>();
            while (doingExercise5)
            {
                for (int i = 1; i < 3; i++)
                {
                    if (numbers5.Count() < 1)
                    {
                        Console.Write("Enter your first number: ");
                        string userInput = Console.ReadLine();
                        Console.WriteLine("");
                        bool isANumber = double.TryParse(userInput, out double userDouble);
                        if (isANumber)
                        {
                            numbers5.Add(userDouble);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                            Console.WriteLine("Press enter and let's try again");
                            Console.ReadLine();
                            i = 0;
                            doingExercise5 = false;
                        }
                    }
                    else if (numbers5.Count() <= 1)
                    {
                        Console.Write("Enter your second number: ");
                        string userInput = Console.ReadLine();
                        Console.WriteLine("");
                        bool isANumber = double.TryParse(userInput, out double userDouble);
                        if (isANumber)
                        {
                            numbers5.Add(userDouble);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                            Console.WriteLine("Press enter and let's try again");
                            Console.ReadLine();
                            if (numbers5.Count() == 1)
                            {
                                i = 1;
                                doingExercise5 = true;
                            }
                            else
                            {
                                doingExercise5 = false;
                            }
                        }
                    }

                }
                if (numbers5.Count() <= 1)
                {

                }
                else if (numbers5.Count() == 2)
                {
                    int theTotal = 1;
                    foreach (int i in numbers5)
                    {
                        theTotal = theTotal * i;
                    }
                    Console.WriteLine($"The product of your two numbers is: {theTotal}");
                }
                doingExercise5 = false;
            }
            Console.WriteLine("");

            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise6()
        {
            Console.WriteLine("EXERCISE 6:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Use a do-while loop to output 'Hello, World!' in a loop. " +
                "Each time you output 'Hello, World!' ask the user whether they would like to continue.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool printingHelloWorld = true;
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("");

                bool askingUser = true;
                while(askingUser)
                {
                    Console.WriteLine("Would you like to print this phrase again?");
                    Console.Write("Enter 'y' or 'yes' to continue, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        printingHelloWorld = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        printingHelloWorld = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            while (printingHelloWorld);

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise7()
        {
            Console.WriteLine("EXERCISE 7:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Use a do-while loop to run exercise 1 in a loop. " +
                "Each time you run the code ask the user whether they would like to continue.");
            Console.WriteLine("");
            Console.WriteLine("EXERCISE 1:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a string. " +
                "After the user enters a string, output the same string back to the console.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise1 = true;
            do
            {
                DoExercise1();
                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise1 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise1 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            while (doingExercise1);

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise8()
        {
            Console.WriteLine("EXERCISE 8:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Make exercises 2-5 run in a loop. Use a do-while loop to run the code in a loop. " +
                "Each time you run the code ask the user whether they would like to continue.");
            Console.WriteLine("");
            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a number. " +
                "After the user enters a number, add 1 to the number and output it back to the console.");
            Console.WriteLine("");
            Console.WriteLine("EXERCISE 3:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a number. " +
                "After the user enters a number, add .5 to the number and output it back to the console.");
            Console.WriteLine("");
            Console.WriteLine("Exercise 4:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.");
            Console.WriteLine("");
            Console.WriteLine("Exercise 5:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise8 = true;
            do
            {
                DoExercise2();
                DoExercise3();
                DoExercise4();
                DoExercise5();
                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise8 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise8 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            while (doingExercise8);

            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
