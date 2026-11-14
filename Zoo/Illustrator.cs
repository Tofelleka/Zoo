using System;
using System.Collections.Generic;

namespace Zoo
{
    internal static class Illustrator
    {
        internal static void ShowMainMenu(List<string> enclosureLines, List<string> menuLines)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");
            Console.WriteLine("                             ЗООПАРК                                  ");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            Console.WriteLine("\n  ВОЛЬЕРЫ:                              ДОСТУПНЫЕ ДЕЙСТВИЯ:");
            Console.WriteLine("  ---------------------------------     ------------------------------");

            int maxLines = Math.Max(enclosureLines.Count, menuLines.Count);

            for (int i = 0; i < maxLines; i++)
            {
                string left = i < enclosureLines.Count ? enclosureLines[i] : "";
                string right = i < menuLines.Count ? menuLines[i] : "";

                Console.WriteLine($"{left,-40} | {right}");
            }

            Console.WriteLine("======================================================================");
        }

        internal static void ShowEnclosureInfo(string name, string description, List<string> animalLines, int males, int females)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("======================================================================");
            Console.WriteLine($"                     ВОЛЬЕР: {name.ToUpper()}");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            Console.WriteLine($"  Описание: {description}\n");

            Console.WriteLine("  ЖИВОТНЫЕ В ВОЛЬЕРЕ:");
            Console.WriteLine("  ---------------------------------");

            if (animalLines.Count == 0)
            {
                Console.WriteLine("  (вольер пуст)");
            }
            else
            {
                foreach (string line in animalLines)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("  ---------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  Статистика: Самцов - {males}, Самок - {females}");
            Console.ResetColor();
            Console.WriteLine("======================================================================");
            Console.WriteLine("\n  Нажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }

        internal static void ShowErrorInputText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  Неверный ввод! Такого вольера не существует.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}