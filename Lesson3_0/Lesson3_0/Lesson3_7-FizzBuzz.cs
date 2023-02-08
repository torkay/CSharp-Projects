using System;
namespace Lesson3_0
{
	public class FizzBuzz
	{
		public FizzBuzz()
		{
			for (int i = 1; i < 101; i++)
			{
				Console.Write($"{i} ");
				if (i % 3 == 0)
				{
					Console.Write("Fizz");
				}
				if (i % 5 == 0)
				{
					Console.Write("Buzz");
				}
				Console.WriteLine("");
			}
			Console.ReadLine();
		}
	}
}

