using System;
namespace Lesson3_0
{
	public class countToTen
	{
		public countToTen()
		{
			int num = 0;

			while (num <= 10)
			{
				Console.Write($"{num}, ");
				num += 1;
			}

            num = 20;

            while (num >= 0)
            {
                Console.Write($"{num}, ");
                num -= 2;
            }
        }
	}
}

