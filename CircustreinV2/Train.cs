using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{


    public class Train
    {
        private List<Wagon> wagonList;
        public List<Animal> animals;
        public List <Animal> animalsAscending;
        public List <Animal> animalsDescending;

        public Train() 
        { 
            wagonList = new List<Wagon>();
            animals = new List<Animal>();
            animalsAscending = new List<Animal>();
            animalsDescending = new List<Animal>();
        }

        public List<Wagon> GetWagons()
        {
            return wagonList;
        }


        public void SortAnimals()
        {
            // Ascending list:
            animalsAscending = animals
                .OrderBy(a => a.GetSize())  // Small to large by size
                .ThenBy(a => a.GetDiet() == Animal.Diet.Carnivore ? 0 : 1) // Carnivores first
                .ToList();

            // Descending list:
            animalsDescending = animals
                .OrderBy(a => a.GetDiet() == Animal.Diet.Carnivore ? 0 : 1) // Carnivores first
                .ThenBy(a => a.GetDiet() == Animal.Diet.Carnivore
                    ? (int)a.GetSize()  // Carnivores: small to large
                    : -(int)a.GetSize())  // Herbivores: large to small
                .ToList();
        }
        

        public void PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient()
        {


            if (PlaceAnimalsInWagons(animalsAscending) <= PlaceAnimalsInWagons(animalsDescending))
            {
                PlaceAnimalsInWagons(animalsAscending);
            }
            else
            {
                PlaceAnimalsInWagons(animalsDescending);
            }
        }
        private int PlaceAnimalsInWagons(List<Animal> animals)
        {
            wagonList.Clear();
            foreach (var animal in animals)
            {
                if (!TryToAddAnimalToExistingWagons(animal))
                {
                    AddAnimalToNewWagon(animal);
                }
            }
            return wagonList.Count;
        }

        private void AddAnimalToNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagonList.Add(wagon);
            wagon.CanAddAnimal(animal);
        }

        private bool TryToAddAnimalToExistingWagons(Animal animal)
        {
            foreach (var wagon in wagonList)
            {
                if (wagon.CanAddAnimal(animal))
                {
                    return true;
                }
            }
            return false;
        }


        public int GetWagonCount()
        {
            return wagonList.Count;
        }

    }
}
