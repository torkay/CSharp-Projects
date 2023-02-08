// Main program:
using Lesson3_0;

internal class Program
{
    private static void Main(string[] args)
    {
        new FizzBuzz();

        bool loginSuccess = PasswordCheck.SuccessfulEntry();
        Console.WriteLine(loginSuccess);

        if (loginSuccess)
        {


            bool inputSuccess = false;
            Console.WriteLine("Access granted\n");
            while (inputSuccess != true)
            {
                Console.WriteLine("\nLaunchpad: ['1'] = whileExample.cs ['2'] = forExample.cs ['3'] = nestForLoops.cs ['0'] = exit");

                string userInput;

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        inputSuccess = true;
                        break;
                    case "1":
                        Console.WriteLine("\n");
                        new countToTen();
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("\n");
                        new forExample();
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("\n");
                        new nestedForLoops();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Invalid answer, please re-read the query and try again\n");
                        break;
                }
            }
        }

        else
        {
            Console.WriteLine("Access denied\n");
        }
    }
}