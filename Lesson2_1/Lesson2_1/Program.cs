using System;

    public class lesson2_1
    {
        public static void Main()
        {
        // Variable Decleration
        double temperature;
        string input;
        string option;

        checkpoint1:

        Console.WriteLine("To convert from Celcius -> Farenheit type '1', or to convert from Farenheit -> Celcius type '2'");

        Checkpoint1:

        input = Console.ReadLine();

        // Get Temperature Value
        if (input.ToLower().Equals("1"))
        {
            option = "Celcius";
        }
        else if (input.ToLower().Equals("2"))
        {
            option = "Farenheit";
        }
        else
        {
            Console.WriteLine("Sorry, you've inputted an invalid response, please re-read my question and try again");
            goto Checkpoint1;
        }

        Console.WriteLine("Enter Temperature in " + option);
        temperature = double.Parse(Console.ReadLine());

        if (input.ToLower().Equals("1"))
        {
            // Celcius -> Farenheit
            Console.WriteLine(temperature + "℃  ->  " + (temperature * 1.8 + 32) + "℉");
        }
        else if (input.ToLower().Equals("2"))
        {
            // Farenheit -> Celcius
            Console.WriteLine(temperature + "℉  ->  " + ((temperature - 32) * (5 / 9)) + "℃");
        }

        Console.WriteLine("Would you like to create a new entry? ('y' = yes, 'n' = no)");
        option = Console.ReadLine();

        checkpoint2:

        if (option.Equals("y"))
        {
            goto checkpoint1;
        }
        else if (option.Equals("n"))
        {
            Console.WriteLine("Press any key to close program");
        }
        else
        {
            Console.WriteLine("Your entry is invalid, pleade re-read my question more carefully then try again");
            goto checkpoint2;
        }

        Console.ReadKey();
        }
    }