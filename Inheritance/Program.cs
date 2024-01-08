using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            var cardinal = new Bird();

            cardinal.Color = "Red";
            cardinal.DoesItNest = true;
            cardinal.IsItMigratory = true;
            cardinal.Name = "Cardinal";
            cardinal.Diet = "Worms";
            cardinal.IsAggressive = true;
            cardinal.LifeExpectancy = 5;
            cardinal.Species = "Cardinalis cardinalis";

            Console.WriteLine("See below for data for the cardinal inherited from the animal class.");
            cardinal.DisplayAnimalData();
            Console.WriteLine("-------------------------");
            Console.WriteLine("See below for data from the bird class for the cardinal.");
            cardinal.DisplayBirdData();
            Console.WriteLine("-------------------------");

            var crocodile = new Reptile();

            crocodile.CanItRegenerate = false;
            crocodile.IsItAmphibious = true;
            crocodile.TeethAmount = 66;
            crocodile.Name = "Crocodile";
            crocodile.Diet = "Small dogs and human limbs";
            crocodile.Species = "Crocodylidae";
            crocodile.IsAggressive = true;
            crocodile.LifeExpectancy = 40;

            Console.WriteLine("See below for data for the crocodile inherited from the animal class.");
            crocodile.DisplayAnimalData();
            Console.WriteLine("-------------------------");
            Console.WriteLine("See below for data from the reptile class for the crocodile.");
            crocodile.DisplayReptileData();
            Console.WriteLine("-------------------------");

        }
    }
}
