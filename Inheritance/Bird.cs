using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		public string Name { get; set; }
		public bool DoesItNest { get; set; }
		public string Color { get; set; }
		public bool IsItMigratory { get; set; }

		public void DisplayBirdData()
		{
			Console.WriteLine($"The {Name} is a {Color} bird. Does it nest? {DoesItNest}. Is it migratory? {IsItMigratory}");
		}
	}
}

