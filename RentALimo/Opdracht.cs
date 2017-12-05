﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    //opdracht in apart project steken?
    class Opdracht
    {
        public Wagen Wagen { get; set; }
        public Klant Klant { get; set; }
        public Locatie VertrekLocatie { get; set; }
        public Locatie AankomstLocatie { get; set; }
        public Arrangement Arrangement { get; set; }
        //dit in aparte klasse steken?
        public Prijs Prijs { get; set; }
        //??
        public Tijd Tijd { get; set; }
        public DateTime BoekingsDatum { get; set; }
    }
}
