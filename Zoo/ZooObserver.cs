using System;

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


            switch (GetEnclosureType())
            {
                case EnclosureType.Savannah:
                    break;

                case EnclosureType.Forest:
                    break;

                case EnclosureType.Pond:
                    break;

                case EnclosureType.Suburb:
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        private EnclosureType GetEnclosureType()
        {
            bool isWork = true;

            while (isWork)
            {
                int userInput = Utils.ReadNumber() - 1;

                if (Enum.IsDefined(typeof(EnclosureType), userInput))
                {
                    return (EnclosureType)userInput;
                }
            }

            return EnclosureType.Forest;
        }
    }
}
