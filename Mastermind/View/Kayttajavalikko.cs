using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastermind.Controller;
using Mastermind.Model;

namespace Mastermind
{
    public partial class Kayttajavalikko : Form
    {
        private Paavalikko paavalikko;
        Ohjain registerHandler =  new Ohjain();
        string a;
        int x;

        public Kayttajavalikko(Paavalikko paavalikko)
        {
            InitializeComponent();

            this.paavalikko = paavalikko;

            if (tbKayttaja.Text.ToString() == "")
            {
                btUusiKayttaja.Enabled = false;
            }

            if (cbKayttaja.Text.ToString() == "")
            {
                btValitse.Enabled = false;
            }            
        }

        private void btPaavalikko_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btUusiKayttaja_Click(object sender, EventArgs e)
        {
            Kayttajat kayttaja = new Kayttajat();
            kayttaja.Kayttaja = tbKayttaja.Text.ToString();

            registerHandler.TallennaKayttaja(kayttaja);

            MessageBox.Show("Käyttäjä lisätty");

            //this.Hide();
            //using (var pelilauta = new Pelilauta(this))
            //{
            //    a = tbKayttaja.Text;
            //    pelilauta.ab(a.ToString());
            //    pelilauta.ShowDialog();
            //    this.Show();
                
            //}

            //Close();
        }

        private void cbKayttaja_MouseClick(object sender, MouseEventArgs e)
        {
            cbKayttaja.DataSource = registerHandler.KaikkiKayttajat();
            cbKayttaja.DisplayMember = "kayttaja";
            cbKayttaja.ValueMember = "kayttajaId";

            btValitse.Enabled = true;
        }

        private void tbKayttaja_TextChanged(object sender, EventArgs e)
        {
            if (tbKayttaja.Text.ToString() != "")
            {
                btUusiKayttaja.Enabled = true;
            }
        }

        private void btValitse_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
