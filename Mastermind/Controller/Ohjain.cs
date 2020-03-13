using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Mastermind.Model;

namespace Mastermind.Controller
{
    public class Ohjain
    {
        DatabaseHallinta dbController = new DatabaseHallinta();

        public bool TallennaKayttaja(Kayttajat kayttaja)
        {
            bool didItGoIntoDatabase = dbController.UusiKayttaja(kayttaja);
            return didItGoIntoDatabase;
        }

        public List<Kayttajat> KaikkiKayttajat()
        {
            return dbController.KaikkiKayttajatTietokannasta();

        }

        public bool Haviot(Kayttajat kayttaja)
        {
            bool havio = dbController.Havio(kayttaja);
            return havio;
        }

        public bool HavioSaavutus(Kayttajat kayttaja)
        {
            bool saavutus = dbController.HavioSaavutus(kayttaja);
            return saavutus;
        }

        public bool Voitot(Kayttajat kayttaja)
        {
            bool voitto = dbController.Voitto(kayttaja);
            return voitto;
        }

        public bool VoittoSaavutus(Kayttajat kayttaja)
        {
            bool saavutus = dbController.VoittoSaavutus(kayttaja);
            return saavutus;
        }

        public DataSet Tilastot()
        {
            return dbController.TilastotTietokannasta();
        }
    }
}
