// Class file with the method:
using System;
using Lesson3_0;

namespace Lesson3_0
{
    public class PasswordCheck
    {
        public static bool SuccessfulEntry()
        {
            bool successfulEntry = false;
            int passwordAttempts = 0;
            string input;

            while (!successfulEntry)
            {
                if (passwordAttempts != 0)
                {
                    Console.WriteLine($"Incorrect, Attempt {passwordAttempts}\n");

                    if (passwordAttempts == 3)
                    {
                        Console.WriteLine("Attempt limit reached");
                        return false;
                    }
                }

                if (passwordAttempts != 3)
                {
                    Console.WriteLine("Enter Password:");
                    input = Console.ReadLine();

                    if (input == "123")
                    {
                        Console.WriteLine("\nSuccessful Attempt");
                        return true;
                    }
                    else
                    {
                        passwordAttempts++;
                    }
                }
            }
            return false;
        }
    }
}