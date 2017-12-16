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
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Kleur { get; set; }
        public WagenPrijs WagenPrijs { get; set; }

        //code Dirk Andries
        //public bool HeeftArrangement(Arrangement arrangement)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

