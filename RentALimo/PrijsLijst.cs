using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    public class PrijsLijst
    {
        public int Id { get; set; }
        private const decimal BtwPercentage = 6;

        //List = correcte datatype?
        public IEnumerable<PrijsLijstItem> Items { get; protected set; } = new List<PrijsLijstItem>();
    }
}
