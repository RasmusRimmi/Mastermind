using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Model
{
    public class Kayttajat
    {
        int kayttajaId;
        string kayttaja;
        int voitot;
        int haviot;

        public int KayttajaId { get => kayttajaId; set => kayttajaId = value; }
        public string Kayttaja { get => kayttaja; set => kayttaja = value; }
        public int Voitot { get => voitot; set => voitot = value; }
        public int Haviot { get => haviot; set => haviot = value; }
    }
}
