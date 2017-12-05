using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    class Klant
    {
        public KlantCategorie KlantCategorie { get; set; }
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public string BtwNummer { get; set; }
        public string KlantNummer { get; set; }
        //met een vast BTW-percentage werken?
        public Btw BtwPercentage { get; set; }
    }
}
