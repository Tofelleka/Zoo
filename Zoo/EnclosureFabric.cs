using System;
using System.Collections.Generic;

namespace Zoo
{
    internal static class EnclosureFabric
    {
        private static List<(AnimalType type, string name, string discription)> _enclosures = new List<(AnimalType typpe, string name, string discription)>
        {
            { (AnimalType.Leon, "Саванна", "Жаркая саванна с хищными кошками." )},
            { (AnimalType.Wolf, "Лес", "Густой лес с волками." )},
            { (AnimalType.Drake, "Пруд", "Водоём с птицами." )},
            { (AnimalType.Crow, "Пригороод", "Пригородный участок с воронами." )}
        };
        private static Dictionary<AnimalType, (string name, Genders gender, string sound)> _animalCatalog = new Dictionary<AnimalType, (string name, Genders gender, string sound)>
        {
            {AnimalType.Leon ,("Лев", (Genders)Utils.GetRandomNumber(0,Enum.GetValues(typeof(Genders)).Length), "Р-р-р!")},
            {AnimalType.Wolf ,("Волк", (Genders)Utils.GetRandomNumber(0,Enum.GetValues(typeof(Genders)).Length), "Аууууууфф")},
            {AnimalType.Drake ,("Селезень", (Genders)Utils.GetRandomNumber(0,Enum.GetValues(typeof(Genders)).Length), "Кря-кря")},
            {AnimalType.Crow ,("Ворона", (Genders)Utils.GetRandomNumber(0,Enum.GetValues(typeof(Genders)).Length), "Кар-кар")}
        };

        internal static List<Enclosure> CreateEnclosures()
        {
            List<Enclosure> enclosures = new List<Enclosure>();

            for (int i = 0; i < _enclosures.Count; i++)
            {
                Enclosure temp = GetEnclosure(i);

                for (int j = 0; j < Utils.GetRandomNumber(1,enclosures.Capacity); j++)
                {
                    GetAnimal(_enclosures[i].type);
                }

                enclosures.Add(temp);
            }

            return enclosures;
        }

        private static Enclosure GetEnclosure(int number)
        {
            var data = _enclosures[number];

            return new Enclosure(data.name, data.discription, new List<Animal>());
        }

        private static Animal GetAnimal(AnimalType type)
        {
            var data = _animalCatalog[type];

            return new Animal(data.name, data.gender, data.sound);
        }
    }

    public enum AnimalType
    {
        Leon = 0,
        Wolf = 1,
        Drake = 2,
        Crow = 3
    }
}
