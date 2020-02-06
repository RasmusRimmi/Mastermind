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

        public DataTable Tilastot()
        {
            return dbController.TilastotTietokannasta();
        }
    }
}
