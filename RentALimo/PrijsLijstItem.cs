using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    //er bestaat een vaste prijslijst. Hoe incorporeren?
    public class PrijsLijstItem
    {
        public int Id { get; set; }
        //correcte plaats?
        public Arrangement Arrangement { get; set; }
        public decimal Prijs { get; set; }
    }
}
