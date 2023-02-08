using System;
namespace Lesson3_0
{
	public class userInputCheck
	{
		public userInputCheck()
		{
			//long testnum = inputFromUser("Give me a number");

			//Console.WriteLine($"Your Number Squareed is {testnum*testnum}");

			YesNoInput();

			Console.ReadKey();
		}

		private long inputFromUser(string myQuestion)
		{
			long num;

			Console.WriteLine(myQuestion);

			while (!long.TryParse(Console.ReadLine(), out num))
			{
				Console.WriteLine("Invalid number");
				Console.WriteLine(myQuestion);
			}

			return (num);
		}

		private string YesNoInput()
		{
			string answer;
			answer = Console.ReadLine().ToLower();

			while (!answer.Equals("yes") && !answer.Equals("no"))
			{
				Console.WriteLine("Invalid input, try again");
				Console.WriteLine("Type YES or NO then press ENTER");
				answer = Console.ReadLine().ToLower();
			}

			return (answer);
		}
	}
}

