﻿using System;
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

        //Lisää uuden käyttäjän tietokantaan
        public bool UusiKayttaja(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query1 = new SqlCommand("INSERT INTO Kayttajat(Kayttaja, Voitot, Haviot, Total) VALUES(@Kayttaja, 0, 0, 0)", dbYhteys);
            SqlParameter Kayttaja = new SqlParameter("@Kayttaja", kayttaja.Kayttaja);
            
            query1.Parameters.Add(Kayttaja);

            query1.ExecuteNonQuery();

            dbYhteys.Close();
            return true;
        }

        //Näyttää kaikki käyttäjät tietokannasta
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

        //Lisää häviön käyttäjälle
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

        //Antaa saavutuksen käyttäjälle 3:nnen ja 10:nnen häviön jälkeen
        public bool HavioSaavutus(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query = new SqlCommand("SELECT Haviot FROM Kayttajat WHERE KayttajaId=@KayttajaId", dbYhteys);
            SqlParameter Kayttaja1 = new SqlParameter("@KayttajaId", kayttaja.Haviot);
            query.Parameters.Add(Kayttaja1);
            SqlDataReader havio = query.ExecuteReader();

            if (havio.Read())
            {
                Kayttajat User = new Kayttajat();
                User.Haviot = (int)havio["Haviot"];

                if (User.Haviot == 10)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 9)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter Paska2 = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(Paska2);
                    query2.ExecuteNonQuery();
                }

                else if (User.Haviot == 3)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 8)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter Paska2 = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(Paska2);
                    query2.ExecuteNonQuery();

                }
            }

            dbYhteys.Close();
            return true;
        }

        //Lisää voiton käyttäjälle
        public bool Voitto(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query4 = new SqlCommand("UPDATE Kayttajat SET Voitot = Voitot + 1 WHERE KayttajaId = @KayttajaId", dbYhteys);
            SqlParameter Kayttaja = new SqlParameter("@KayttajaId", kayttaja.Voitot);
            query4.Parameters.Add(Kayttaja);

            query4.ExecuteNonQuery();

            dbYhteys.Close();
            return true;
        }

        //Antaa saavutuksen käyttäjälle 1:sen, 3:nnen ja 10:nnen voiton jälkeen
        public bool VoittoSaavutus(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query = new SqlCommand("SELECT Voitot FROM Kayttajat WHERE KayttajaId=@KayttajaId", dbYhteys);
            SqlParameter Kayttaja1 = new SqlParameter("@KayttajaId", kayttaja.Voitot);
            query.Parameters.Add(Kayttaja1);
            SqlDataReader voitto = query.ExecuteReader();

            if (voitto.Read())
            {
                Kayttajat user = new Kayttajat();
                user.Voitot = (int)voitto["Voitot"];

                if (user.Voitot == 1)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 7)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter Paska2 = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(Paska2);
                    query2.ExecuteNonQuery();
                }

                else if (user.Voitot == 3)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 3)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter Paska2 = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(Paska2);
                    query2.ExecuteNonQuery();

                }

                else if (user.Voitot == 10)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 5)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter Paska2 = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(Paska2);
                    query2.ExecuteNonQuery();

                }
            }
            dbYhteys.Close();

            return true;
        }

        //Saavutus, jos käyttäjä arvaa rivin oikein ensimmäisellä kieroksella
        public bool SuperVoitto(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query = new SqlCommand("SELECT KayttajaId FROM Kayttajat WHERE KayttajaId=@KayttajaId", dbYhteys);
            SqlParameter Kayttaja1 = new SqlParameter("@KayttajaId", kayttaja.KayttajaId);
            query.Parameters.Add(Kayttaja1);
            SqlDataReader havio = query.ExecuteReader();

            if (havio.Read())
            {
                dbYhteys.Close();
                dbYhteys.Open();
                KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 6)" +
                    "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                    "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                    "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                SqlParameter sqlParam = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                query2.Parameters.Add(sqlParam);
                query2.ExecuteNonQuery();
            }

            dbYhteys.Close();
            return true;
        }

        //Päivittää käyttäjän pelikertojen määrän
        public bool PeliSaavutus(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query = new SqlCommand("UPDATE Kayttajat SET Total = Voitot + Haviot WHERE KayttajaId = @KayttajaId", dbYhteys);
            SqlParameter parametriVoitto = new SqlParameter("@KayttajaId", kayttaja.Total);
            query.Parameters.Add(parametriVoitto);

            query.ExecuteNonQuery();

            dbYhteys.Close();
            return true;
        }

        //Saavutus, jos käyttäjä on pelannut 1:sen, 5:nnen tai 10:nnen kerran
        public bool PeliSaavutusLisays(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query = new SqlCommand("SELECT Total FROM Kayttajat WHERE KayttajaId=@KayttajaId", dbYhteys);
            SqlParameter Kayttaja1 = new SqlParameter("@KayttajaId", kayttaja.Total);
            query.Parameters.Add(Kayttaja1);
            SqlDataReader pelikerta = query.ExecuteReader();

            if (pelikerta.Read())
            {
                Kayttajat kayttaja2 = new Kayttajat();
                kayttaja2.Total = (int)pelikerta["Total"];

                if (kayttaja2.Total == 1)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 1)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter sqlParam = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(sqlParam);
                    query2.ExecuteNonQuery();
                }

                else if (kayttaja2.Total == 5)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 2)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter sqlParam = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(sqlParam);
                    query2.ExecuteNonQuery();
                }

                else if (kayttaja2.Total == 10)
                {
                    dbYhteys.Close();
                    dbYhteys.Open();
                    KayttajienSaavutukset kaytsaav = new KayttajienSaavutukset();
                    SqlCommand query2 = new SqlCommand("INSERT INTO Kayttajiensaavutukset(KayttajaId, SaavutusId) VALUES(@KayttajaId, 4)" +
                        "SELECT Kayttajat.KayttajaId, Saavutukset.SaavutusId FROM ((Kayttajiensaavutukset " +
                        "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId) " +
                        "INNER JOIN Saavutukset ON KayttajienSaavutukset.SaavutusId = Saavutukset.SaavutusId)", dbYhteys);
                    SqlParameter sqlParam = new SqlParameter("@KayttajaId", Kayttaja1.Value);
                    query2.Parameters.Add(sqlParam);
                    query2.ExecuteNonQuery();
                }
            }
            dbYhteys.Close();

            return true;
        }

        //Näyttää käyttäjien voitot
        public DataSet VoitotTietokannasta()
        {
            Kayttajat user = new Kayttajat();
            dbYhteys.Open();
            SqlCommand query5 = new SqlCommand("SELECT Kayttaja, Voitot FROM Kayttajat ORDER BY Voitot  DESC", dbYhteys);

            SqlDataAdapter sda = new SqlDataAdapter(query5);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dbYhteys.Close();

            return ds;
        }

        //Näyttää käyttäjien häviöt
        public DataSet HaviotTietokannasta()
        {
            Kayttajat user = new Kayttajat();
            dbYhteys.Open();
            SqlCommand query5 = new SqlCommand("SELECT Kayttaja, Haviot FROM Kayttajat ORDER BY Haviot  DESC", dbYhteys);

            SqlDataAdapter sda = new SqlDataAdapter(query5);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dbYhteys.Close();

            return ds;
        }

        //Näyttää käyttäjien saavutukset
        public DataTable SaavutuksetTietokannasta(Kayttajat kayttaja)
        {
            dbYhteys.Open();
            SqlCommand query4 = new SqlCommand("SELECT Saavutukset.Saavutus, Saavutukset.Kriteeri FROM((Kayttajiensaavutukset " +
                                               "INNER JOIN Saavutukset ON Kayttajiensaavutukset.SaavutusId = Saavutukset.SaavutusId)" +
                                               "INNER JOIN Kayttajat ON Kayttajiensaavutukset.KayttajaId = Kayttajat.KayttajaId)" +
                                               "WHERE Kayttajat.Kayttaja = @Kayttaja", dbYhteys);
            SqlParameter Kayttaja = new SqlParameter("@Kayttaja", kayttaja.Kayttaja);
            query4.Parameters.Add(Kayttaja);

            query4.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(query4);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dbYhteys.Close();

            return dt;
        }

    }
}
