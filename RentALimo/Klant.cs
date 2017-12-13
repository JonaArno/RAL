using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    public class Klant
    {
        public int Id { get; set; }
        public KlantCategorie KlantCategorie { get; set; }
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        public string BtwNummer { get; set; }
        public string KlantNummer { get; set; }
    }
}
