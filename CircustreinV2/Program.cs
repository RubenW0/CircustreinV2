using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein;
using CircustreinV2;

namespace Circustrein
{
    internal class Program
    {
        public static List<Animal> animals;

        static void Main()
        {
            animals = new List<Animal>();

            animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));
            animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Small));
            animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Medium));
            animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));
            animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));

            PrintAnimalList();
        }

        static void PrintAnimalList()
        { 
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal Diet: {animal.GetDiet()}, Size: {animal.GetSize()}");
            }
        }
    }
}
