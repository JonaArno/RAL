using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    public class Wagen
    {
        public int Id { get; set; }
        //ev te combineren
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Kleur { get; set; }
        public PrijsLijst PrijsLijst { get; set; }
         }
    }
}
