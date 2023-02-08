using System;

public class Lesson2_1
{
    public static string Calculate(string user, string sum)
    {
        if (user == sum)
        {
            return "Correct!";
        }
        else
        {
            return "Incorrect, the answer is " + sum;
        }
    }

    public static void Main()
    {
        restart:

        int score = 0;
        string placeholder;

        // Generating Random Numbers
        Random random = new Random();
        int num1 = random.Next(2, 12);
        int num2 = random.Next(1, num1);

        // Calculations
        string ans1 = "" + (num1 * num2);
        string ans2 = "" + (num1 / num2);
        string ans3 = "" + (num1 + num2);
        string ans4 = "" + (num1 - num2);

        // Questions
        Console.WriteLine("What does " + num1 + " x " + num2 + " = ?");
        string input = Console.ReadLine();
        string response = Calculate(input, ans1);
        Console.WriteLine(response);
        if (response == "Correct!") score++;

        Console.WriteLine("What does " + num2 + " / " + num1 + " = ?");
        input = Console.ReadLine();
        response = Calculate(input, ans2);
        Console.WriteLine(response);
        if (response == "Correct!") score++;

        Console.WriteLine("What does " + num1 + " + " + num2 + " = ?");
        input = Console.ReadLine();
        response = Calculate(input, ans3);
        Console.WriteLine(response);
        if (response == "Correct!") score++;

        Console.WriteLine("What does " + num1 + " - " + num2 + " = ?");
        input = Console.ReadLine();
        response = Calculate(input, ans4);
        Console.WriteLine(response);
        if (response == "Correct!") score++;

        Console.WriteLine("Your score was " + score + "/4");

        Console.WriteLine("Would you like to play again? ('y' = yes, 'n' = no)");

        attributeError:

        placeholder = Console.ReadLine();

        if (placeholder.Equals("y"))
        {
            Console.WriteLine("Alright! Let's play again");
            goto restart;
        }
        else if (placeholder.Equals("n"))
        {
            Console.WriteLine("Alright, got it - Press any key to close application");
        }
        else
        {
            Console.WriteLine("Sorry, you've entered an invalid response, please re-read my question and try again");
            goto attributeError;
        }

        Console.ReadKey();
    }
}