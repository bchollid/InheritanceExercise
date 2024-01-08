using System;
namespace Inheritance
{
	public class Animal
	{
		public Animal()
		{
		}

		public string Diet { get; set; }

		public string Species { get; set; }

		public bool IsAggressive { get; set; }

		public int LifeExpectancy { get; set; }

		public void DisplayAnimalData()
		{
			Console.WriteLine($"The life expectancy of the {Species} is {LifeExpectancy} years. It eats primarily {Diet}. Is it aggressive? {IsAggressive}");
		}
	}
}

