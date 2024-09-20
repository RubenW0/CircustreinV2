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
        public static Train train = new Train();

        static void Main()
        {
            animals = new List<Animal>();

            //train.animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));
            //train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Small));
            //train.animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Medium));
            //train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            //train.animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));
            //train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));

            train.animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));
            train.animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));
            train.animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));

            train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));
            train.animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));



            train.SortAnimals();
            train.PrintSortedAnimals();
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();
            train.PrintDistribution();

        }

    }
}
