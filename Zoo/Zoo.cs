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

        internal void ShowEnclosure(EnclosureType type)
        {
            foreach(Enclosure enclosure in _enclosure)
            {
                if(enclosure.Type == type)
                {
                    return;
                }
            }
        }
    }
}