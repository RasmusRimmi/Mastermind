using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mastermind.Model
{
    public class DatabaseHallinta
    {
    
        SqlConnection dbYhteys = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Mastermind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public DatabaseHallinta()
        {

        }

        public bool UusiKayttaja(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query1 = new SqlCommand("INSERT INTO Kayttajat(Kayttaja, Voitot, Haviot) VALUES(@Kayttaja, 0, 0)", dbYhteys);
            SqlParameter Kayttaja = new SqlParameter("@Kayttaja", kayttaja.Kayttaja);
            
            query1.Parameters.Add(Kayttaja);

            query1.ExecuteNonQuery();

            dbYhteys.Close();
            return true;
        }

        public List<Kayttajat> KaikkiKayttajatTietokannasta()
        {
            dbYhteys.Open();
            SqlCommand query2 = new SqlCommand("SELECT KayttajaId, Kayttaja FROM  Kayttajat", dbYhteys);
            SqlDataReader kayttaja = query2.ExecuteReader();
            List<Kayttajat> kayttajaLista = new List<Kayttajat>();

            while (kayttaja.Read())
            {
                Kayttajat tunnus = new Kayttajat();
                tunnus.KayttajaId = (int)kayttaja["KayttajaId"];
                tunnus.Kayttaja = (string)kayttaja["Kayttaja"];
                kayttajaLista.Add(tunnus);
            }
            dbYhteys.Close();
            return kayttajaLista;
        }

        public bool Havio(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query3 = new SqlCommand("UPDATE Kayttajat SET Haviot = Haviot + 1 WHERE KayttajaId = @KayttajaId", dbYhteys);
            SqlParameter Kayttaja = new SqlParameter("@KayttajaId", kayttaja.Haviot);
            query3.Parameters.Add(Kayttaja);

            query3.ExecuteNonQuery();

            dbYhteys.Close();
            return true;
        }

        public bool Voitto(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query4 = new SqlCommand("UPDATE Kayttajat SET Voitot = Voitot + 1 WHERE KayttajaId = @KayttajaId", dbYhteys);
            SqlParameter Kayttaja = new SqlParameter("@KayttajaId", kayttaja.Haviot);
            query4.Parameters.Add(Kayttaja);

            query4.ExecuteNonQuery();

            dbYhteys.Close();
            return true;
        }

        public DataTable TilastotTietokannasta()
        {
            dbYhteys.Open();
            SqlCommand query5 = new SqlCommand("SELECT Kayttaja, Voitot, Haviot FROM Kayttajat", dbYhteys);

            query5.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(query5);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dbYhteys.Close();

            return dt;
        }

    }
}
