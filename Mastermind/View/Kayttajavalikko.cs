using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Mastermind.Controller;
using Mastermind.Model;


namespace Mastermind
{
    public partial class Kayttajavalikko : Form
    {
        Ohjain registerHandler =  new Ohjain();
        string a;
        int x;

        public Kayttajavalikko(Paavalikko paavalikko)
        {
            InitializeComponent();

            //Lisää käyttäjä-nappi pois käytöstä
            if (tbKayttaja.Text.ToString() == "")
            {
                btUusiKayttaja.Enabled = false;
            }

            //Valitse-nappi pois käytöstä
            if (cbKayttaja.Text.ToString() == "")
            {
                btValitse.Enabled = false;
            }      
            
            //Katsotaan onko mute-nappi päällä vai ei 
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.on;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.off;
            }

            tbKayttaja.MaxLength = 6;
            lbLisays.Hide();
        }

        //Avataan päävalikko
        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Paavalikko paavalikko = ((Paavalikko)Owner);
            this.Close();
        }

        //Lisää käyttäjän tietokantaan
        private void btUusiKayttaja_Click(object sender, EventArgs e)
        {
            Kayttajat kayttaja = new Kayttajat();
            kayttaja.Kayttaja = tbKayttaja.Text.ToString();

            registerHandler.TallennaKayttaja(kayttaja);

            lbLisays.Show();
            //MessageBox.Show("Käyttäjä lisätty");
        }

        //Hakee käyttäjät tietokannasta
        private void cbKayttaja_MouseClick(object sender, MouseEventArgs e)
        {
            cbKayttaja.DataSource = registerHandler.KaikkiKayttajat();
            cbKayttaja.DisplayMember = "kayttaja";
            cbKayttaja.ValueMember = "kayttajaId";

            btValitse.Enabled = true;
        }

        //Teksikenttään kun kirjoitetaan niin uusi käyttäjä-nappi laitetaan painettavaksi
        private void tbKayttaja_TextChanged(object sender, EventArgs e)
        {
            if (tbKayttaja.Text.ToString() != "")
            {
                btUusiKayttaja.Enabled = true;
            }

        }

        //Valitaan comboboxista valittu käyttäjä ja avataan pelilauta
        private void btValitse_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var ohjeet = new Ohjeet(this))
            {
                ohjeet.ShowDialog();
            }

            using (var pelilauta = new Pelilauta(this))
            {
                a = cbKayttaja.Text;
                x = (int)cbKayttaja.SelectedValue;
                pelilauta.ab(a.ToString());
                pelilauta.yx(x);
                pelilauta.ShowDialog();
                this.Show();
            }

            Close();
        }

        //Musiikin hiljennys napin toiminnot.
        private void btMute_Click(object sender, EventArgs e)
        {
            //Nappia klikatessa musiikki pysähtyy tai jatkuu
            if (Paavalikko.mute == true)
            {
                btMute.BackgroundImage = Properties.Resources.off;
                Paavalikko.menu.Stop();
                Paavalikko.mute = false;
            }

            else if (Paavalikko.mute == false)
            {
                btMute.BackgroundImage = Properties.Resources.on;
                Paavalikko.menu.PlayLooping();
                Paavalikko.mute = true;
            }
        }

        private void tbKayttaja_Click(object sender, EventArgs e)
        {
            lbLisays.Hide();
            tbKayttaja.Clear();
        }
    }
}
