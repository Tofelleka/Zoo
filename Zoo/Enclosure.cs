using System.Collections.Generic;

namespace Zoo
{
    internal class Enclosure
    {
        internal const int Capacity = 10;

        private List<Animal> _animals;

        internal Enclosure(string name, string discription, List<Animal> animals)
        {
            Name = name;
            Description = discription;
            _animals = animals;
        }

        public string Name { get;private set; }
        public string Description { get; private set; }

        internal void AddAnimal(Animal animal)
        {
            if (Capacity > _animals.Count)
            {
                _animals.Add(animal);
            }
        }

        internal List<Animal> GetAnimals()
        {
            List<Animal> tempAnimals = new List<Animal>();

            foreach(Animal animal in _animals)
            {
                tempAnimals.Add(animal);
            }

            return tempAnimals;
        }

        internal int CountAnimals()
        {
            return _animals.Count;
        }

        internal int CountByGender(Gender gender)
        {
            int count = 0;

            foreach(Animal animal in _animals)
            {
                if(animal.Gender == gender)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
