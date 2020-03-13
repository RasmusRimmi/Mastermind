using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Model
{
    class KayttajienSaavutukset
    {
        int kayttajaId;
        int saavutusId;

        public int KayttajaId { get => kayttajaId; set => kayttajaId = value; }
        public int SaavutusId { get => saavutusId; set => saavutusId = value; }
    }
}
