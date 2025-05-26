using System.Collections.Generic;
using Domain.Models;
using Domain.Interfaces;
using Infrastructure.Repositories;

namespace Service
{
    // Service der håndterer logik for dyr i systemet
    public class AnimalService
    {
        private IAnimalRepository _animalRepository; // Repository til dataadgang

        // Constructor – opretter repository-instans
        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }

        // Henter alle dyr fra repository
        public List<Animal> GetAllAnimals()
        {
            return _animalRepository.GetAll();
        }

        // Filtrerer dyr efter art (species)
        public List<Animal> FilterBySpecies(string species)
        {
            List<Animal> allAnimals = _animalRepository.GetAll();
            List<Animal> filtered = new List<Animal>();

            foreach (Animal animal in allAnimals)
            {
                if (species == "" || animal.Species == species)
                {
                    filtered.Add(animal);
                }
            }

            return filtered;
        }

        // Tilføjer et nyt dyr
        public void AddAnimal(Animal animal)
        {
            _animalRepository.Add(animal);
        }

        // Gemmer hele listen af dyr
        public void SaveAnimals(List<Animal> animals)
        {
            _animalRepository.SaveAll(animals);
        }
    }
}
