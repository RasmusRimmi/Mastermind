using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Model
{
    public class Saavutukset
    {
        int saavutusId;
        string saavutus;

        public int SaavutusId { get => saavutusId; set => saavutusId = value; }
        public string Saavutus { get => saavutus; set => saavutus = value; }
    }
}
