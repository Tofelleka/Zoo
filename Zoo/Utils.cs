using System;

namespace Zoo
{
    internal static class Utils
    {
        private static Random _random = new Random();

        public static int ReadNumber()
        {
            bool isWork = true;

            int numberForReturn = 0;

            while (isWork)
            {
                if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
                {
                    isWork = false;
                    numberForReturn = number;
                }
                else
                {
                    Console.WriteLine("\n\nНеверный ввод, это должно быть положительное число или 0.");
                }
            }

            return numberForReturn;
        }

        public static int GetRandomNumber(int minNumber, int maxNumber)
        {
            return _random.Next(minNumber, maxNumber);
        }
    }
}