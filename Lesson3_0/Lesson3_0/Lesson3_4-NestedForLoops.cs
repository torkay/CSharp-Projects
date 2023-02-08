namespace Lesson3_0
{
	public class nestedForLoops
	{
		public nestedForLoops()
		{
			int num1 = 1;
			int num2 = 1;

			for (int i = 1; i <= 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.WriteLine($"{num1*i} x {num2*j+1} = {(num1*i) * (num2*j+1)}");
				}
			}
		}
	}
}