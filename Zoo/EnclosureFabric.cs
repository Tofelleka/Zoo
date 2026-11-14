using System;
using System.Collections.Generic;

namespace Zoo
{
    internal static class EnclosureFabric
    {
        private static List<(EnclosureType enclosureType, AnimalType animalType, string name, string description)> _enclosures =
            new List<(EnclosureType enclosureType, AnimalType animalType, string name, string description)>
        {
            { (EnclosureType.Savannah, AnimalType.Leon, "Саванна", "Жаркая саванна с хищными кошками." )},
            { (EnclosureType.Forest, AnimalType.Wolf, "Лес", "Густой лес с волками." )},
            { (EnclosureType.Pond, AnimalType.Drake, "Пруд", "Водоём с птицами." )},
            { (EnclosureType.Suburb, AnimalType.Crow, "Пригороод", "Пригородный участок с воронами." )}
        };
        private static Dictionary<AnimalType, (string name, string sound)> _animalCatalog = new Dictionary<AnimalType, (string name, string sound)>
        {
            {AnimalType.Leon ,("Лев", "Р-р-р!")},
            {AnimalType.Wolf ,("Волк", "Аууууууфф")},
            {AnimalType.Drake ,("Селезень", "Кря-кря")},
            {AnimalType.Crow ,("Ворона", "Кар-кар")}
        };

        internal static List<Enclosure> CreateEnclosures()
        {
            List<Enclosure> enclosures = new List<Enclosure>();

            for (int i = 0; i < _enclosures.Count; i++)
            {
                int quantityAnimals = Utils.GetRandomNumber(1, Enclosure.Capacity + 1);

                Enclosure temp = GetEnclosure(i);

                for (int j = 0; j < quantityAnimals; j++)
                {
                    temp.AddAnimal(GetAnimal(_enclosures[i].animalType));
                }

                enclosures.Add(temp);
            }

            return enclosures;
        }

        private static Enclosure GetEnclosure(int number)
        {
            var data = _enclosures[number];

            return new Enclosure(data.enclosureType,data.name, data.description, new List<Animal>());
        }

        private static Animal GetAnimal(AnimalType type)
        {
            var data = _animalCatalog[type];

            return new Animal(data.name, (Gender)Utils.GetRandomNumber(0, Enum.GetValues(typeof(Gender)).Length), data.sound);
        }
    }
}