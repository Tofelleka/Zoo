using System.Collections.Generic;

namespace Zoo
{
    internal class Zoo
    {
        List<Enclosure> _enclosures;

        internal Zoo()
        {
            _enclosures = EnclosureFabric.CreateEnclosures();
        }

        internal Enclosure ShowEnclosure(EnclosureType type)
        {
            foreach(Enclosure enclosure in _enclosures)
            {
                if(enclosure.Type == type)
                {
                    return enclosure;
                }
            }

            return null;
        }

        internal List<Enclosure> GetEnclosures()
        {
            return new List<Enclosure>(_enclosures);
        }
    }
}