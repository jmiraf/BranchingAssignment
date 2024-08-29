using System;
using System.Diagnostics.Eventing.Reader;

namespace BranchingAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
			Console.WriteLine("Enter package weight:");
			int weight = Convert.ToInt32(Console.ReadLine());
			if (weight > 50)
				{
				Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
				}
			else
				{
				Console.WriteLine("Enter package width:");
				int width = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter package height:");
				int height = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter package length:");
				int length = Convert.ToInt32(Console.ReadLine());
				int dimension = Convert.ToInt32(length) + Convert.ToInt32(height) + Convert.ToInt32(width);
				Console.WriteLine("Total dimensions: " + dimension);
					if (dimension > 50)
					{
					Console.WriteLine("Package too heavy to be shipped via Package Express.");
					}
					else 
					{
					int quote = Convert.ToInt32(length) * Convert.ToInt32(height) * Convert.ToInt32(width);
					int shipcost = Convert.ToInt32(quote) * Convert.ToInt32(weight) / 100;
					Console.WriteLine("Your estimated total for shipping this package is: $" + shipcost);
					Console.WriteLine("Thank you!");
					Console.ReadLine();
					}
			}
			
		}
	}
}
