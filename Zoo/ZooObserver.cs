using System;
using System.Collections.Generic;

namespace Zoo
{
    internal class ZooObserver
    {
        private const int ExitCommand = 0;

        private Zoo _zoo;

        internal ZooObserver(Zoo zoo)
        {
            _zoo = zoo;
        }

        internal void Run()
        {
            bool isWork = true;

            while (isWork)
            {
                List<string> enclosureLines = new List<string>();
                List<Enclosure> enclosures = _zoo.GetEnclosures();

                for (int i = 0; i < enclosures.Count; i++)
                {
                    enclosureLines.Add($"  {i + 1} - {enclosures[i].Name}");
                }

                List<string> menuLines = new List<string>
                {
                    $"  {ExitCommand} - Выйти из зоопарка",
                    "",
                    "  Введите номер вольера:"
                };

                Illustrator.ShowMainMenu(enclosureLines, menuLines);

                int userInput = Utils.ReadNumber();

                if (userInput == ExitCommand)
                {
                    isWork = false;
                    break;
                }

                int index = userInput - 1;

                if (index >= 0 && index < enclosures.Count)
                {
                    VisitEnclosure(enclosures[index]);
                }
                else
                {
                    Illustrator.ShowErrorInputText();
                }
            }
        }

        private void VisitEnclosure(Enclosure enclosure)
        {
            List<string> animalLines = new List<string>();

            foreach (Animal animal in enclosure.GetAnimals())
            {
                string genderStr = animal.Gender == Gender.Male ? "Самец" : "Самка";
                animalLines.Add($"  - {animal.Name} ({genderStr}) издает звук: {animal.Sound}");
            }

            int males = enclosure.CountByGender(Gender.Male);
            int females = enclosure.CountByGender(Gender.Female);

            Illustrator.ShowEnclosureInfo(enclosure.Name, enclosure.Description, animalLines, males, females);
        }
    }
}