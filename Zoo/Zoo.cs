using System.Collections.Generic;

namespace Zoo
{
    internal class Zoo
    {
        List<Enclosure> _enclosure;

        internal Zoo()
        {
            _enclosure = EnclosureFabric.CreateEnclosures();
        }

        internal List<Enclosure> GetEnclosures()
        {
            List<Enclosure> tempEnclusure = new List<Enclosure>();

            foreach(Enclosure enclosure in _enclosure)
            {
                tempEnclusure.Add(enclosure);
            }

            return tempEnclusure;
        }
    }
}
