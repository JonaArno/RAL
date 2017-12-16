using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALimo
{
    //zelfde properties als in reservering (Opdracht)
    //public class ReserveringBouwer
    //{
    //    public DateTime? Datum { get; set; }
    //    public Klant Klant { get; set; }
    //    public Periode Periode { get; set; }
    //    public Arrangement? Arrangement { get; set; }
    //    public Locatie? StartLocatie { get; set; }
    //    public Locatie? EindLocatie { get; set; }
    //    public Wagen Wagen { get; set; }

    //    public Reservering Maak()
    //    {
    //        if (!IsGeldig())
    //        {
    //            throw new InvalidOperationException(Status());
    //        }

    //        var result = new Reservering
    //        {
    //            Arrangement = Arrangement.Value,
    //            Periode = Periode
    //            // enz.. //PrijsInfo = PrijsBerekenaarFebriek() klasse?
    //        }; 

    //        return result;
    //    }

    //    //zeer uitgebreid
    //    private bool IsGeldig()
    //    {
    //        return Klant != null &&
    //               Periode != null &&
    //               Wagen != null &&
    //               Arrangement != null &&
    //               Datum.HasValue &&
    //               StartLocatie.HasValue &&
    //               EindLocatie.HasValue &&
    //               Wagen.HeeftArrangement(Arrangement.Value) &&
    //               Periode.Duur <= Periode.MaximaleDuur &&
    //               //Arrangement.Value.IsGeldigStartuur(Periode.StartUur) &&
    //               WagenIsVrij();
    //    }

    //    //kan je niet overlaten aan de datalaag, want je moet rekening houden met de buffers vooraan en achteraan
    //    private bool WagenIsVrij()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    private string Status()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
