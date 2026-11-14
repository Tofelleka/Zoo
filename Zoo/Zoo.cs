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

        internal List<Enclosure> GetEnclosures()
        {
            return new List<Enclosure>(_enclosures);
        }
    }
}