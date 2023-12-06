using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_3
{
    public class Biler
    {
       public string _bilmerke = "";
       public int _årsmodell = 0;
       public int _kmstand = 0;
       public string _regnr = "";

        public Biler(string bilmerke, int årsmodell, int kmstand, string regnr)
        {
            _bilmerke = bilmerke;
            _årsmodell = årsmodell;
            _kmstand = kmstand;
            _regnr = regnr;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"{_bilmerke} Årsmodell: {_årsmodell} Km/stand: {_kmstand} Regnr: {_regnr}");
            

        }

    }
}
