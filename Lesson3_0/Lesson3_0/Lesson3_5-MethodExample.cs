using System;
namespace Lesson3_0
{
    public class methodExample
	{
        int num1 = 1000;
        int num2 = 500;

        public methodExample()
		{
			Console.WriteLine(Addition(num1, num2));
			Console.WriteLine(Subtraction(num1, num2));
			Console.WriteLine(Multiplication(num1, num2));
			Console.WriteLine(Division(num1, num2));
			Console.WriteLine(Division(Multiplication(num1, num2), Addition(num1, num2)));
		}

		private int Addition(int n1, int n2)
		{
			int result = n1 + n2;
			return (result);
		}

		private int Subtraction(int n1, int n2)
		{
			int result = n1 - n2;
			return (result);
		}

		private int Multiplication(int n1, int n2)
		{
			int result = n1 * n2;
			return (result);
		}

		private double Division(double n1, double n2)
		{
			double result = n1 / n2;
			return (result);
		}

	}
}