using System;

namespace factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			static int getFactorial(int number)
			{
				if (number == 1)
				{
					return 1;
				}
				return number * getFactorial(number - 1);
			}

			
			{
				int givenNumber;

				Console.WriteLine("Enter a number to find the factorial ");
				givenNumber = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Factorial : {0}", getFactorial(givenNumber));

			}
		}
	}
}
		
