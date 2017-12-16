using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    public class Periode
    {
        public DateTime? StartDatum { get; set; }
        public DateTime? EindDatum { get; set; }
        public const int maxDuur = 11; 
        public Periode(Arrangement arr, DateTime start, DateTime eind)
        {
            //...
            
        }

        public TimeSpan GetDuur()
        
        {
            //EindMoment - StartMoment
            TimeSpan dummy = new TimeSpan();
            return dummy;
        }
    }
}
