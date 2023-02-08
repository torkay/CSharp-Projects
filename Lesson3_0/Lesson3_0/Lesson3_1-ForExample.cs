using System;
namespace Lesson3_0
{
	public class forExample
	{
		public forExample()
		{
			int max = 10;

			for (int i = 0; i <= max; i++)
			{
				Console.Write($"{i}, ");
			}

			Console.WriteLine("\n");

			int min = 0;

			for (int i = 20; i >= min; i-=2)
			{
				Console.Write($"{i}, ");
			}

			Console.WriteLine("\n");

			max = 100;

            for (int i = 0; i <= max; i += 5)
			{
                Console.Write($"{i}, ");
            }  
        }
	}
}