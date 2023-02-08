using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int rangeLow = 1;
        int rangeHigh = 101;

        bool playGame = true;
        bool playFair = true;

        var random = new Random();

        while (playGame && playFair == true)
        {
            if (rangeHigh - rangeLow == 0)
            {
                Console.WriteLine("Wait a second... You're not playing fair!");
                playFair = false;
                break;
            }

            int guess = random.Next(rangeLow, rangeHigh);

            Console.WriteLine($"Hmm... I think {guess}\nAm I: 'correct', 'too high', or 'too low'");
            string response = null;

            bool safetyNet = true;

            while (safetyNet == true)
            {
                response = Console.ReadLine();

                if (response.Equals("correct") || response.Equals("too high") || response.Equals("too low"))
                {
                    safetyNet = false;
                }
                else
                {
                    Console.WriteLine("Invalid response, please re-read my question and try again!");
                }
            }

            switch (response)
            {
                case "correct":
                    Console.WriteLine("Yay! I always win.");
                    playGame = false;
                    break;

                case "too high":
                    rangeHigh = guess - 1;
                    break;

                case "too low":
                    rangeLow = guess + 1;
                    break;
            }
        }
        Console.WriteLine("Press any key to close the program");
        Console.ReadKey();
    }
}