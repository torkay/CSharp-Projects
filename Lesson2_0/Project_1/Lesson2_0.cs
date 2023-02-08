public class lesson2
{
    public static string Answer(float width, float length)
    {
        Start2:

        string response = "";
        string input;

        Console.WriteLine("Would you like Area, type 'a', or Perimeter, type 'p', or both 'b'");
        input = Console.ReadLine();

        if (input.ToLower().Equals("a"))
        {
            response = ("Area of shape is equal to " + (width * length));
        }

        else if (input.ToLower().Equals("p"))
        {
            response = ("Perimeter of shape is equal to " + (width + length) * 2);
        }

        else if (input.ToLower().Equals("b"))
        {
            response = ("Area of shape is equal to " + (width * length) + "\n" + "Perimeter of shape is equal to " + (width + length) * 2);
        }
        else
        {
            Console.WriteLine("Sorry, your answer was invalid, please read my question more carefully and retry");
            goto Start2;
        }

        return response;
    }

    public static void Main()
    {
        Start1:

        // Variable Decleration
        float length;
        float width;
        string input;

        // Get Length Value
        Console.WriteLine("Length of the peremeter");
        length = float.Parse(Console.ReadLine());

        // Get Width Value
        Console.WriteLine("Width of the parameter");
        width = float.Parse(Console.ReadLine());

        // Shape Calculation
        Console.WriteLine(Answer(width, length) + "\nWould you like to reset the calculator and try again? ('y' for yes, 'n' for no)");
        input = Console.ReadLine();

        // Reset Calculator
        Start3:
        if (input.ToLower().Equals("y"))
        {
            goto Start1;
        }
        else if (input.ToLower().Equals("n"))
        {

        }
        else
        {
            Console.WriteLine("Sorry, your answer was invalid, please read my question more carefully and retry");
            goto Start3;
        }



    }
}