using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public string Name { get; set; }
		public bool CanItRegenerate { get; set; }
		public bool IsItAmphibious { get; set; }
		public int TeethAmount { get; set; }

        public void DisplayReptileData()
        {
            Console.WriteLine($"The {Name} has {TeethAmount} teeth. Can it regenerate? {CanItRegenerate}. Is it ampihibious? {IsItAmphibious}.");
        }
    }

	
}

