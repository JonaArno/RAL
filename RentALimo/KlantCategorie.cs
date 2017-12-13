using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    public class KlantCategorie
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public EventingKorting EventingKorting { get; set; }

    }
}

