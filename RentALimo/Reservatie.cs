using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    //opdracht in apart project steken?
    public class Reservatie
    {
        public int Id { get; set; }
        public Klant Klant { get; set; }
        public Wagen Wagen { get; set; }
        public Locatie VertrekLocatie { get; set; }
        public Locatie AankomstLocatie { get; set; }
        public Arrangement Arrangement { get; set; }
        public decimal Prijs { get; }
        public Periode Periode { get; set; }
        //noodzakelijk?
        public DateTime BoekingsDatum { get; set; }
        
        public Reservatie( /*.........*/)
        {
            //
        }


    }
}
